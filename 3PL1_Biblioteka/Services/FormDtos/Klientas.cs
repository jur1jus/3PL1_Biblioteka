using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FormDtos
{
	public record Klientas(int? Id, string Vardas, string Pavardė, string Elpaštas, Image paveiksliukas, Guid kortelėsId);
}
