using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Drawing;
using System.IO;
using System.Net;
using System.Drawing.Imaging;

namespace Services
{
	public class KlietaiService : IDisposable
	{
		private readonly BibliotekaDbContext _db;

		public KlietaiService()
		{
			_db = new BibliotekaDbContext();
		}

		private byte[] GaukPaveiksliuką()
		{
			var nuoroda = ConfigurationManager.AppSettings["paveiksliukųGeneravimoUrl"];

			using (HttpClient httpClient = new HttpClient()) {
				var paveiksliukoBytes = httpClient.GetByteArrayAsync(nuoroda).Result;
				return paveiksliukoBytes;
			}
		}

		public Tuple<Bitmap, byte[]> SuformuokPaveiksliuką()
		{
			var paveiksliukoBytes = GaukPaveiksliuką();

			using (MemoryStream mStream = new()) {
				mStream.Write(paveiksliukoBytes, 0, paveiksliukoBytes.Length);
				var paveiksliukas = new Bitmap(mStream, false);
				return new Tuple<Bitmap, byte[]>(paveiksliukas, paveiksliukoBytes);
			}
		}

		public void SaugokKlientą(FormDtos.Klientas klientas)
		{
			//1.Sugeneruoti paveiksliuko filename'ą
			//2.Įrašyti duomenis į duomenų bazę
			//3.Išsaugoti paveiksliuką į FTP serverį arba į failinę sistemą

			var paveiksliukoFileName = GeneruokPaveiksliukoFilePavadinimą(klientas);

			using (var tran = _db.Database.BeginTransaction()) {
				try {

					if (!klientas.Id.HasValue) {
						var klientasDb = new Domain.Klientas(klientas.Vardas, klientas.Pavardė, klientas.Elpaštas, klientas.kortelėsId.ToString(), paveiksliukoFileName);

						_db.Klientai.Add(klientasDb);
					}

					var nuotraukųFolderis = ConfigurationManager.AppSettings["klientųNuotraukųFolderis"];

					ĮkelkFailąĮFtp(nuotraukųFolderis, paveiksliukoFileName, klientas.Paveiksliukas);

					_db.SaveChanges();
					tran.Commit();
				} catch {
					tran.Rollback();
					throw;
				}
			}
		}

		private string GeneruokPaveiksliukoFilePavadinimą(FormDtos.Klientas klientas)
		{
			return $"{klientas.Vardas}_{klientas.Pavardė}_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_dd")}.jpg";
			//Testas_Testauskas_2021-05-08_10_05_33
		}

		public void ĮkelkFailąĮFtp(string uri, string failoPavadinimas, byte[] failas)
		{
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri + failoPavadinimas);
			request.Method = WebRequestMethods.Ftp.UploadFile;

			//request.Credentials = new NetworkCredential("username", "password");

			using (Stream ftpStream = request.GetRequestStream())
				ftpStream.Write(failas, 0, failas.Length);
		}

		public void Dispose()
		{
			_db.Dispose();
		}
	}
}
