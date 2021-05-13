using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	[Table("Autoriai")]
	public class Autorius
	{
		[Key]
		public int Id { get; private set; }

		public string Vardas { get; private set; }

		public string Pavardė { get; private set; }

		public DateTime? GimimoData { get; private set; }

		public string Šalis { get; private set; }

		public string GyvenimoAprašymas { get; private set; }

		public string Slapyvardis { get; private set; }

		private Autorius() { }
	}
}