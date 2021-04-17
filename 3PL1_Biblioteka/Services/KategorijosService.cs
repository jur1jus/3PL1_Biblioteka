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

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				//Sunaikinsime DbContextą
			}
		}
	}
}
