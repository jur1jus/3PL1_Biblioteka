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
	public partial class KategorijosSaugojimas : Form
	{
		public delegate void KategorijosIšsaugojimas(Kategorija kategorija);

		private KategorijosIšsaugojimas _kategorijosIšsaugojimas;

		public KategorijosSaugojimas(KategorijosIšsaugojimas kategorijosIšsaugojimas)
		{
			InitializeComponent();
			_kategorijosIšsaugojimas = kategorijosIšsaugojimas;
		}

		private void btnSaugoti_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPavadinimas.Text)) {
				MessageBox.Show("Įveskite kategorijos pavadinimą.");
			}

			if (txtPavadinimas.Text.Length > 50) {
				MessageBox.Show("Kategorijos pavadinimas neturi būti ilgesnis nei 50 simbolių.");
			}

			var id = string.IsNullOrEmpty(txtId.Text) ? (int?)null : int.Parse(txtId.Text);
			var pavadinimas = txtPavadinimas.Text;
			var amžiausCenzūra = string.IsNullOrEmpty(txtAmžiausCenzūra.Text) ? (int?)null : int.Parse(txtAmžiausCenzūra.Text);

			Kategorija kategorija = new(id, pavadinimas, amžiausCenzūra);

			_kategorijosIšsaugojimas(kategorija);
		}
	}
}
