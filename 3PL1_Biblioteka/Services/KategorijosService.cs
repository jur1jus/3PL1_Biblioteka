using Domain;
using Microsoft.EntityFrameworkCore;
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

		public List<Kategorija> GaukKategorijas(FormDtos.KategorijosPaieška kategorijosPaieška)
		{
			//var kategorijos = (from kategorija in _dbContext.Kategorijos
			//				   select kategorija).ToList();

			return _dbContext.Kategorijos
						.Where(m => !m.ArIštrintas
								&& (kategorijosPaieška.Pavadinimas == null || m.Pavadinimas.Contains(kategorijosPaieška.Pavadinimas))
								&& (kategorijosPaieška.AmžiausCenzūra == null || m.AmžiausCenzūra == kategorijosPaieška.AmžiausCenzūra))
						.ToList();
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

		public void NaikinkKategoriją(int id)
		{
			var kategorija = _dbContext.Kategorijos
								.Where(k => k.Id == id)
								.First();

			kategorija.Pasinaikink();

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
