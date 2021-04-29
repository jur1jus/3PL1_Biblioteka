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
			GaukSąrašoDuomenis(GaukPaieškosLaukus());
		}

		~Kategorijos()
		{
			_kategorijosService.Dispose();
		}

		private void GaukSąrašoDuomenis(KategorijosPaieška kategorijosPaieška)
		{
			var kategorijos = _kategorijosService.GaukKategorijas(kategorijosPaieška);

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
			GaukSąrašoDuomenis(GaukPaieškosLaukus());
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
				GaukSąrašoDuomenis(GaukPaieškosLaukus());
			}
		}

		private void textBox2_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				GaukSąrašoDuomenis(GaukPaieškosLaukus());
			}
		}

		private KategorijosPaieška GaukPaieškosLaukus()
		{
			var pavadinimasPaieška = string.IsNullOrWhiteSpace(txtPaieškaPavadinimas.Text) ? null : txtPaieškaPavadinimas.Text;
			var amžiausCenzūraPaieška = int.TryParse(txtPaieškaAmžiausCenzūra.Text, out int amžiausCenzūra) ? (int?)amžiausCenzūra : (int?)null;

			KategorijosPaieška paiešką = new(pavadinimasPaieška, amžiausCenzūraPaieška);
			return paiešką;
		}

		private void txtPaieškaPavadinimas_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				GaukSąrašoDuomenis(GaukPaieškosLaukus());
			}
		}
	}
}
