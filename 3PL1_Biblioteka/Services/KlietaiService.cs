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

				Stream stream = new MemoryStream(paveiksliukoBytes);

				FileStream fs = new FileStream("", FileMode.Create, FileAccess.ReadWrite);
				stream.CopyTo(fs);
				return paveiksliukoBytes;
			}
		}

		public Bitmap SuformuokPaveiksliuką()
		{
			var paveiksliukoBytes = GaukPaveiksliuką();
			byte[] pData = paveiksliukoBytes;

			using (MemoryStream mStream = new()) {
				mStream.Write(pData, 0, pData.Length);
				return new(mStream, false);
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
					var nuotraukosBytes = ImageToBytes(klientas.paveiksliukas);

					//ĮkelkFailąĮFtp(nuotraukųFolderis, paveiksliukoFileName, nuotraukosBytes);

					_db.SaveChanges();
					tran.Commit();
				} catch {
					tran.Rollback();
					throw;
				}
			}
		}

		private byte[] ImageToBytes(Image paveiksliukas)
		{
			MemoryStream ms = new();
			paveiksliukas.
			return ms.ToArray();
		}

		private string GeneruokPaveiksliukoFilePavadinimą(FormDtos.Klientas klientas)
		{
			return $"{klientas.Vardas}_{klientas.Pavardė}_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_dd")}";
			//Testas_Testauskas_2021-05-08_10_05_33
		}

		public void ĮkelkFailąĮFtp(string uri, string failoPavadinimas, byte[] failas)
		{
			FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri + failoPavadinimas);
			request.Method = WebRequestMethods.Ftp.UploadFile;

			//request.Credentials = new NetworkCredential("username", "password");

			Stream ftpStream = request.GetRequestStream();
			ftpStream.Write(failas, 0, failas.Length);
		}

		public void Dispose()
		{
			_db.Dispose();
		}
	}
}
