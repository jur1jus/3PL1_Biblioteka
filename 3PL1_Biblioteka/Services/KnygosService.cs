using Domain;
using Services.FormDtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class KnygosService : IDisposable
	{
		private readonly BibliotekaDbContext _db;

		public KnygosService()
		{
			_db = new BibliotekaDbContext();
		}

		public List<KnygaSąrašui> GaukKnygas()
		{
			var knygos = (from knyga in _db.Knygos
						  join autorius in _db.Autoriai on knyga.AutoriausId equals autorius.Id
						  join kategorija in _db.Kategorijos on knyga.KategorijosId equals kategorija.Id
						  where knyga.ArPašalinta == false
						  select new KnygaSąrašui(knyga.Id, knyga.Pavadinimas, autorius.Vardas + " " + autorius.Pavardė, knyga.Metai, kategorija.Pavadinimas)).ToList();

			return knygos;
		}

		public FormDtos.Knyga SaugokKnygą(FormDtos.Knyga knyga)
		{
			using (var tran = _db.Database.BeginTransaction()) {
				try {
					var failoPavadinimas = Path.GetFileName(knyga.NuotraukosKelias);
					var ftpUri = ConfigurationManager.AppSettings["knygųViršeliųFolderis"];

					Domain.Knyga knygaDb;

					if (knyga.Id.HasValue) {
						//update
						knygaDb = _db.Knygos.Where(m => m.Id == knyga.Id).FirstOrDefault();

						knygaDb.Atnaujink(knyga.Pavadinimas, knyga.KategorijosId, knyga.PuslapiųSkaičius, failoPavadinimas);
					} else {
						//insert
						knygaDb = new Domain.Knyga(knyga.Pavadinimas, knyga.KategorijosId, knyga.PuslapiųSkaičius, failoPavadinimas);
						_db.Knygos.Add(knygaDb);
					}

					_db.SaveChanges();


					ĮkelkFailąĮFtp(ftpUri, failoPavadinimas, knyga.NuotraukosKelias);

					tran.Commit();


					var knygaResult = knyga with { Id = knygaDb.Id };
					return knygaResult;

				} catch {
					tran.Rollback();
					throw;
				}
			}
		}

		public void ĮkelkFailąĮFtp(string uri, string failoPavadinimas, string failoKelias)
		{
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri + failoPavadinimas);
			request.Method = WebRequestMethods.Ftp.UploadFile;

			//request.Credentials = new NetworkCredential("username", "password");

			var failas = File.ReadAllBytes(failoKelias);

			using (Stream ftpStream = request.GetRequestStream())
				ftpStream.Write(failas, 0, failas.Length);
		}

		public List<KnygaPasirinkimui> GaukKnygasPasirinkimui()
		{
			var knygos = _db.Knygos
							.Where(knyga => knyga.ArPašalinta == false)
							.Select(knygaDb => new KnygaPasirinkimui(knygaDb.Id, knygaDb.Pavadinimas))
							.ToList();

			return knygos;
		}

		public List<FormDtos.KnygosEgzempliorius> GaukKnygosEgzempliorius(int knygosId)
		{
			var knygųEgzemplioriai = _db.KnygųEgzemplioriai
										.Where(knygosEgzempliorius => knygosEgzempliorius.KnygosId == knygosId)
										.Select(m => new FormDtos.KnygosEgzempliorius(m.Id, m.Numeris, m.Sekcija, m.Lentyna))
										.ToList();

			return knygųEgzemplioriai;
		}


		public void Dispose()
		{
			_db.Dispose();
		}

		
	}
}
