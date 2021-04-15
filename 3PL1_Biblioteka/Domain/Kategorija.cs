using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Kategorija
	{
		public int Id { get; set; }

		public string Pavadinimas { get; set; }

		public int? AmžiausCenzūra { get; set; }
	}
}
