using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FormDtos
{
	public record KnygaSąrašui(int Id, string Pavadinimas, string Autorius, int? Metai, string Kategorija);
}
