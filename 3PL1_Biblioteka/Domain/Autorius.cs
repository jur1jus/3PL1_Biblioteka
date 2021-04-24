using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Autorius
	{
		public int Id { get; private set; }

		public string Vardas { get; private set; }

		public string Pavardė { get; private set; }

		public DateTime? GimimoData { get; private set; }

		public string Šalis { get; private set; }

		public string GyvenimoAprašymas { get; private set; }

		public string Slapyvardis { get; private set; }
	}
}
