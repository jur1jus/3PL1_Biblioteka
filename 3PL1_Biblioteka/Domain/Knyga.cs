using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	[Table("Knygos")]
	public class Knyga
	{
		[Key]
		public int Id { get; private set; }

		public string Pavadinimas { get; private set; }

		public int? AutoriausId { get; private set; }

		public int? Metai { get; private set; }

		public int? KategorijosId { get; private set; }

		public int? PuslapiųSkaičius { get; private set; }

		public bool ArPašalinta { get; private set; }

		public DateTime ĮrašoData { get; private set; }

		public string ViršelioNuotraukosPath { get; private set; }

		private Knyga() { }

		public Knyga(string pavadinimas, int? kategorijosId, int? puslapiųSkaičius, string viršelioNuotraukosPath)
		{
			Pavadinimas = pavadinimas;
			Metai = 2020;
			KategorijosId = kategorijosId;
			PuslapiųSkaičius = puslapiųSkaičius;
			AutoriausId = 1;
			ĮrašoData = DateTime.Now;
			ArPašalinta = false;
			ViršelioNuotraukosPath = viršelioNuotraukosPath;
		}

		public void Atnaujink(string pavadinimas, int? kategorijosId, int? puslapiųSkaičius, string viršelioNuotraukosPath)
		{
			throw new NotImplementedException();
		}
	}
}
