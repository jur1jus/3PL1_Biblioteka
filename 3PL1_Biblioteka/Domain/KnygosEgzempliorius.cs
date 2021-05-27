using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	[Table("KnygųEgzemplioriai")]
	public class KnygosEgzempliorius
	{
		[Key]
		public int Id { get; private set; }

		public int KnygosId { get; private set; }

		public string Numeris { get; private set; }

		public string Sekcija { get; private set; }

		public string Lentyna { get; private set; }

		private KnygosEgzempliorius() { }
	}
}
