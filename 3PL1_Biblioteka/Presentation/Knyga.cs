using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDto = Services.FormDtos;

namespace Presentation
{
	public partial class Knyga : Form
	{
		private readonly KnygosService _service;

		public Knyga()
		{
			_service = new();
			InitializeComponent();
		}

		private void btnKategorija_Click(object sender, EventArgs e)
		{
			Kategorijos kategorijos = new(UžpildykKategorijosPikerį);
			kategorijos.ShowDialog();
		}

		public void UžpildykKategorijosPikerį(int kategorijosId, string kategorijosPavadinimas)
		{
			txtKategorija.Text = kategorijosPavadinimas;
			txtKategorijosId.Text = kategorijosId.ToString();
		}

		private void lblIštrintiKategorija_Click(object sender, EventArgs e)
		{
			txtKategorija.Clear();
			txtKategorijosId.Clear();
		}

		private void btnSaugoti_Click(object sender, EventArgs e)
		{
			var pavadinimas = txtPavadinimas.Text;
			var kategorijosId = !string.IsNullOrEmpty(txtKategorijosId.Text) ? int.Parse(txtKategorijosId.Text) : (int?)null;
			var nuotraukosKelias = txtViršelis.Text;

			var rnd = new Random();
			var puslapiųSkaičius = rnd.Next(1900, 2021);

			FormDto.Knyga knyga = new(null, pavadinimas, puslapiųSkaičius, kategorijosId, nuotraukosKelias);

			try {
				_service.SaugokKnygą(knyga);
			} catch (Exception ex) {
				//_logger.LogError(ex.Message);
				MessageBox.Show("Įvyko klaida knygos saugojime.");
			}

			
		}

		private void btnViršelis_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new())
			if (ofd.ShowDialog() == DialogResult.OK) {
				var failoKelias = ofd.FileName;

				txtViršelis.Text = failoKelias;

				pictureBoxViršelis.Image = new Bitmap(failoKelias);
			}
		}
	}
}
