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
	public partial class Knyga : Form
	{
		public Knyga()
		{
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
	}
}
