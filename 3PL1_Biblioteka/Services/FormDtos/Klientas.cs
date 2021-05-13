using System;

namespace Services.FormDtos
{
	public record Klientas(int? Id, string Vardas, string Pavardė, string Elpaštas, byte[] Paveiksliukas, Guid kortelėsId);
}
