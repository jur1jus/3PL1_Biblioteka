using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	[Table("Klientai")]
	public class Klientas
	{
		[Key]
		public int Id { get; private set; }

		[StringLength(50)]
		public string Vardas { get; private set; }

		[StringLength(50)]
		public string Pavardė { get; private set; }

		[StringLength(100)]
		public string ElPaštas { get; private set; }

		//[StringLength(36)]
		public string KortelėsId { get; private set; }

		public string NuotraukosFailoPavadinimas { get; private set; }

		private Klientas() { }

		public Klientas(string vardas, string pavardė, string elPaštas, string kortelėsId, string nuotraukosFailoPavadinimas)
		{
			Vardas = vardas;
			Pavardė = pavardė;
			ElPaštas = elPaštas;
			KortelėsId = kortelėsId;
			NuotraukosFailoPavadinimas = nuotraukosFailoPavadinimas;
		}
	}
}
