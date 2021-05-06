using Services;
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
	public partial class KlientoRegistracija : Form
	{
		private readonly KlietaiService _service;

		public KlientoRegistracija()
		{
			_service = new KlietaiService();
			InitializeComponent();
		}

		~KlientoRegistracija()
		{
			_service.Dispose();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			var paveiksliukas = _service.SuformuokPaveiksliuką();
			pictureBox1.Image = paveiksliukas;
		}

		private void KlientoRegistracija_Load(object sender, EventArgs e)
		{

		}

		private void btnRegistruoti_Click(object sender, EventArgs e)
		{
			var vardas = txtVardas.Text;
			var pavardė = txtPavardė.Text;
			var elpaštas = txtElPaštas.Text;
			var paveiksliukas = pictureBox1.Image;
			var kortelėsId = Guid.Parse(txtKortelėsId.Text);

			Klientas klientas = new(null, vardas, pavardė, elpaštas, paveiksliukas, kortelėsId);

			_service.SaugokKlientą(klientas);
		}

		private void btnGeneruoti_Click(object sender, EventArgs e)
		{
			var guid = Guid.NewGuid();
			txtKortelėsId.Text = guid.ToString();
		}
	}
}
