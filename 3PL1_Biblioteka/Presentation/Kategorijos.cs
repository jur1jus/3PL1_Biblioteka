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
using Services.FormDtos;

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
			GaukSąrašoDuomenis();
		}

		private void dataGridViewKategorijos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 3) {
				var id = (int)dataGridViewKategorijos["clmnId", e.RowIndex].Value;
				var pavadinimas = dataGridViewKategorijos["clmnPavadinimas", e.RowIndex].Value.ToString();
				var amžiausCenzūra = string.IsNullOrEmpty(dataGridViewKategorijos["clmnAmžiausCenzūra", e.RowIndex].Value?.ToString()) ? (int?)null : (int?)dataGridViewKategorijos["clmnAmžiausCenzūra", e.RowIndex].Value;

				Kategorija redaguojamaKategorija = new(id, pavadinimas, amžiausCenzūra);
				KategorijosSaugojimas kategorijosSaugojimas = new(KategorijosIšsagojimas, redaguojamaKategorija);
				kategorijosSaugojimas.ShowDialog();
			}

			if (e.ColumnIndex == 4) {
				var id = (int)dataGridViewKategorijos["clmnId", e.RowIndex].Value;
				PanaikinkKategorija(id);
			}
		}

		private void PanaikinkKategorija(int id)
		{
			var result = MessageBox.Show("Ar tikrai norite panaikinti kategoriją?", "Kategorijos naikinimas", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes) {
				_kategorijosService.NaikinkKategoriją(id);
				GaukSąrašoDuomenis();
			}
		}
	}
}
