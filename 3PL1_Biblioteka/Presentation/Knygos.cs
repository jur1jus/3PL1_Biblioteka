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
	public partial class Knygos : Form
	{
		private readonly KnygosService _service;

		public Knygos()
		{
			_service = new KnygosService();
			InitializeComponent();
			GaukSąrašoDuomenis();
		}

		private void GaukSąrašoDuomenis()
		{
			var knygos = _service.GaukKnygas();

			dataGridView1.Rows.Clear();

			foreach (var knyga in knygos) {
				var eilutė = dataGridView1.Rows.Add();

				dataGridView1["clmnId", eilutė].Value = knyga.Id;
				dataGridView1["clmnPavadinimas", eilutė].Value = knyga.Pavadinimas;
				dataGridView1["clmnAutorius", eilutė].Value = knyga.Autorius;
				dataGridView1["clmnMetai", eilutė].Value = knyga.Metai;
				dataGridView1["clmnKategorija", eilutė].Value = knyga.Kategorija;
			}
		}

		~Knygos()
		{
			_service.Dispose();
		}


	}
}
