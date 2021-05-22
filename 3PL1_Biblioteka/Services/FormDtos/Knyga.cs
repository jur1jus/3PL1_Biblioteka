using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FormDtos
{
	public record Knyga(int? Id, string Pavadinimas, int? PuslapiųSkaičius, int? KategorijosId, string NuotraukosKelias);
}
