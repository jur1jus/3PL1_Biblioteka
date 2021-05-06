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

		}

		public void Dispose()
		{
			_db.Dispose();
		}
	}
}
