using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class KategorijosService : IDisposable
	{
		private readonly BibliotekaDbContext _dbContext;

		public KategorijosService()
		{
			_dbContext = new BibliotekaDbContext();
		}

		public List<Kategorija> GaukKategorijas()
		{
			//var kategorijos = (from kategorija in _dbContext.Kategorijos
			//				   select kategorija).ToList();

			return _dbContext.Kategorijos.ToList();
		}

		public void SaugokKategoriją(FormDtos.Kategorija kategorija)
		{
			if (kategorija.Id.HasValue) {

				var dbKategorija = (from kategorijaModel in _dbContext.Kategorijos
									where kategorijaModel.Id == kategorija.Id
									select kategorijaModel).FirstOrDefault();

				dbKategorija.Atsinaujink(kategorija.Pavadinimas, kategorija.AmžiausCenzūra);

				//$"UPDATE kategorijos SET Pavadinimas = {kategorija.Pavadinimas}, AmziausCenzura = {kategorija.AmžiausCenzūra} WHERE Id = {kategorija.Id}";
			} else {
				Kategorija dbKategorija = new(kategorija.Pavadinimas, kategorija.AmžiausCenzūra);

				_dbContext.Kategorijos.Add(dbKategorija);
				//$"INSERT INTO kategorijos (Pavadinimas, AmziausCenzura) VALUES ('{kategorija.Pavadinimas}', {kategorija.AmžiausCenzūra})";
			}

			_dbContext.SaveChanges();
			
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				_dbContext.Dispose();
			}
		}
	}
}
