using Services.FormDtos;
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
	public partial class EgzemplioriųGeneravimas : Form
	{
		public delegate void SukurkEgzempliorius(List<KuriamasEgzempliorius> egzemplioriai);

		private readonly int _knygosId;
		private SukurkEgzempliorius _egzemplioriųKūrimas;

		public EgzemplioriųGeneravimas(int knygosId, SukurkEgzempliorius egzemplioriųKūrimas)
		{
			InitializeComponent();
			_knygosId = knygosId;
			_egzemplioriųKūrimas = egzemplioriųKūrimas;
		}

		private void btnGeneruoti_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtEgzemplioriųSkaičius.Text) && !int.TryParse(txtEgzemplioriųSkaičius.Text, out _)) {
				MessageBox.Show("Nenurodytas egzempliorių skaičius.");
				return;
			}

			if (string.IsNullOrEmpty(txtSekcija.Text)) {
				MessageBox.Show("Nenurodyta sekcija.");
				return;
			}

			if (string.IsNullOrEmpty(txtLentyna.Text)) {
				MessageBox.Show("Nenurodyta lentyna.");
				return;
			}
			var egzemplioriųSkaičius = int.Parse(txtEgzemplioriųSkaičius.Text);

			var knygųEgzempliorai = GeneruokEgzempliorius(egzemplioriųSkaičius, txtSekcija.Text, txtLentyna.Text);

			_egzemplioriųKūrimas(knygųEgzempliorai);
			this.Close();
		}

		private List<KuriamasEgzempliorius> GeneruokEgzempliorius(int egzemplioriųSkaičiaus, string sekcija, string lentyna)
		{
			var result = new List<KuriamasEgzempliorius>();

			for (int i = 0; i < egzemplioriųSkaičiaus; i++) {
				var numeris = Guid.NewGuid().ToString();
				var egzempliorius = new KuriamasEgzempliorius(_knygosId, numeris, sekcija, lentyna);
				result.Add(egzempliorius);
			}

			return result;
		}
	}
}
