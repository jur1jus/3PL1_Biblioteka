using Domain;
using Services.FormDtos;
using System;
using System.Collections.Generic;
using System.Linq;
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

		public void Dispose()
		{
			_db.Dispose();
		}
	}
}
