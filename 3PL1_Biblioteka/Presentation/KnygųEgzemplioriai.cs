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
	public partial class KnygųEgzemplioriai : Form
	{
		private readonly KnygosService _service;


		public KnygųEgzemplioriai()
		{
			_service = new KnygosService();
			InitializeComponent();
			ParuoškKnygųSąrašą();
		}

		private void ParuoškKnygųSąrašą()
		{
			var knygos = _service.GaukKnygasPasirinkimui();

			comboBox1.DataSource = new BindingSource(knygos, null);
			comboBox1.DisplayMember = "Pavadinimas";
			comboBox1.ValueMember = "Id";

			comboBox1.SelectedIndex = -1;
		}

		public void UžpildykDataGridView(int knygosId)
		{
			var knygosEgzemplioriai = _service.GaukKnygosEgzempliorius(knygosId);

			dataGridView1.Rows.Clear();

			foreach (var knygosEgzempliorius in knygosEgzemplioriai) {
				var eilutė = dataGridView1.Rows.Add();

				dataGridView1["clmnId", eilutė].Value = knygosEgzempliorius.Id;
				dataGridView1["clmnNumeris", eilutė].Value = knygosEgzempliorius.Numeris;
				dataGridView1["clmnSekcija", eilutė].Value = knygosEgzempliorius.Sekcija;
				dataGridView1["clmnLentyna", eilutė].Value = knygosEgzempliorius.Lentyna;

			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(comboBox1.SelectedItem != null) {
				var knygosId = ((Services.FormDtos.KnygaPasirinkimui)comboBox1.SelectedItem).Id;

				UžpildykDataGridView(knygosId);
			}
		}
	}
}
