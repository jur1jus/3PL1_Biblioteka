using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class Kategorijos : Form
	{
		private readonly KategorijosService _kategorijosService;

		public Kategorijos()
		{
			_kategorijosService = new KategorijosService();
			InitializeComponent();
			GaukSąrašoDuomenis();
		}

		~Kategorijos()
		{
			_kategorijosService.Dispose();
		}

		private void GaukSąrašoDuomenis()
		{
			var kategorijos = _kategorijosService.GaukKategorijas();

			dataGridViewKategorijos.Rows.Clear();

			foreach (var kategorija in kategorijos) {
				var eilutė = dataGridViewKategorijos.Rows.Add();
				dataGridViewKategorijos["clmnId", eilutė].Value = kategorija.Id;
				dataGridViewKategorijos["clmnPavadinimas", eilutė].Value = kategorija.Pavadinimas;
				dataGridViewKategorijos["clmnAmžiausCenzūra", eilutė].Value = kategorija.AmžiausCenzūra;
			}
		}

		private void btnSukurtiKategorija_Click(object sender, EventArgs e)
		{
			KategorijosSaugojimas kategorijosSaugojimas = new(KategorijosIšsagojimas);
			kategorijosSaugojimas.ShowDialog();
		}

		private void KategorijosIšsagojimas(Services.FormDtos.Kategorija kategorija)
		{
			_kategorijosService.SaugokKategoriją(kategorija);
		}
	}
}
