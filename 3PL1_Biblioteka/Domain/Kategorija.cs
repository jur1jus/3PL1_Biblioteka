using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Kategorija
	{
		public int Id { get; private set; }

		public string Pavadinimas { get; private set; }

		public int? AmžiausCenzūra { get; private set; }

		public bool ArIštrintas { get; private set; }

		public Kategorija(string pavadinimas, int? amžiausCenzūra)
		{
			Pavadinimas = pavadinimas;
			AmžiausCenzūra = amžiausCenzūra;
			ArIštrintas = false;
		}

		public void Atsinaujink(string pavadinimas, int? amžiausCenzūra)
		{
			Pavadinimas = pavadinimas;
			AmžiausCenzūra = amžiausCenzūra;
		}

		public void Pasinaikink()
		{
			ArIštrintas = true;
		}
	}
}
