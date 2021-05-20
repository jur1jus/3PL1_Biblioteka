
namespace Presentation
{
	partial class Kategorijos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewKategorijos = new System.Windows.Forms.DataGridView();
			this.btnSukurtiKategorija = new System.Windows.Forms.Button();
			this.txtPaieškaPavadinimas = new System.Windows.Forms.TextBox();
			this.txtPaieškaAmžiausCenzūra = new System.Windows.Forms.TextBox();
			this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnPavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnAmžiausCenzūra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnRedaguoti = new System.Windows.Forms.DataGridViewButtonColumn();
			this.clmnIštrinti = new System.Windows.Forms.DataGridViewButtonColumn();
			this.clmnPasirinkti = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewKategorijos
			// 
			this.dataGridViewKategorijos.AllowUserToAddRows = false;
			this.dataGridViewKategorijos.AllowUserToDeleteRows = false;
			this.dataGridViewKategorijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewKategorijos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnPavadinimas,
            this.clmnAmžiausCenzūra,
            this.clmnRedaguoti,
            this.clmnIštrinti,
            this.clmnPasirinkti});
			this.dataGridViewKategorijos.Location = new System.Drawing.Point(-1, 90);
			this.dataGridViewKategorijos.Name = "dataGridViewKategorijos";
			this.dataGridViewKategorijos.ReadOnly = true;
			this.dataGridViewKategorijos.RowTemplate.Height = 25;
			this.dataGridViewKategorijos.Size = new System.Drawing.Size(544, 296);
			this.dataGridViewKategorijos.TabIndex = 0;
			this.dataGridViewKategorijos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategorijos_CellContentClick);
			// 
			// btnSukurtiKategorija
			// 
			this.btnSukurtiKategorija.Location = new System.Drawing.Point(411, 12);
			this.btnSukurtiKategorija.Name = "btnSukurtiKategorija";
			this.btnSukurtiKategorija.Size = new System.Drawing.Size(120, 23);
			this.btnSukurtiKategorija.TabIndex = 1;
			this.btnSukurtiKategorija.Text = "Sukurti kategorija";
			this.btnSukurtiKategorija.UseVisualStyleBackColor = true;
			this.btnSukurtiKategorija.Click += new System.EventHandler(this.btnSukurtiKategorija_Click);
			// 
			// txtPaieškaPavadinimas
			// 
			this.txtPaieškaPavadinimas.Location = new System.Drawing.Point(48, 61);
			this.txtPaieškaPavadinimas.Name = "txtPaieškaPavadinimas";
			this.txtPaieškaPavadinimas.Size = new System.Drawing.Size(138, 23);
			this.txtPaieškaPavadinimas.TabIndex = 2;
			this.txtPaieškaPavadinimas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPaieškaPavadinimas_KeyUp);
			// 
			// txtPaieškaAmžiausCenzūra
			// 
			this.txtPaieškaAmžiausCenzūra.Location = new System.Drawing.Point(196, 61);
			this.txtPaieškaAmžiausCenzūra.Name = "txtPaieškaAmžiausCenzūra";
			this.txtPaieškaAmžiausCenzūra.Size = new System.Drawing.Size(140, 23);
			this.txtPaieškaAmžiausCenzūra.TabIndex = 3;
			this.txtPaieškaAmžiausCenzūra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
			// 
			// clmnId
			// 
			this.clmnId.HeaderText = "";
			this.clmnId.Name = "clmnId";
			this.clmnId.ReadOnly = true;
			this.clmnId.Visible = false;
			// 
			// clmnPavadinimas
			// 
			this.clmnPavadinimas.HeaderText = "Pavadinimas";
			this.clmnPavadinimas.Name = "clmnPavadinimas";
			this.clmnPavadinimas.ReadOnly = true;
			this.clmnPavadinimas.Width = 150;
			// 
			// clmnAmžiausCenzūra
			// 
			this.clmnAmžiausCenzūra.HeaderText = "Amžiaus cenzūra";
			this.clmnAmžiausCenzūra.Name = "clmnAmžiausCenzūra";
			this.clmnAmžiausCenzūra.ReadOnly = true;
			this.clmnAmžiausCenzūra.Width = 150;
			// 
			// clmnRedaguoti
			// 
			this.clmnRedaguoti.HeaderText = "";
			this.clmnRedaguoti.Name = "clmnRedaguoti";
			this.clmnRedaguoti.ReadOnly = true;
			this.clmnRedaguoti.Text = "Redaguoti";
			this.clmnRedaguoti.UseColumnTextForButtonValue = true;
			// 
			// clmnIštrinti
			// 
			this.clmnIštrinti.HeaderText = "";
			this.clmnIštrinti.Name = "clmnIštrinti";
			this.clmnIštrinti.ReadOnly = true;
			this.clmnIštrinti.Text = "Ištrinti";
			this.clmnIštrinti.UseColumnTextForButtonValue = true;
			// 
			// clmnPasirinkti
			// 
			this.clmnPasirinkti.HeaderText = "";
			this.clmnPasirinkti.Name = "clmnPasirinkti";
			this.clmnPasirinkti.ReadOnly = true;
			this.clmnPasirinkti.Text = "Pasirinkti";
			this.clmnPasirinkti.UseColumnTextForButtonValue = true;
			// 
			// Kategorijos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 385);
			this.Controls.Add(this.txtPaieškaAmžiausCenzūra);
			this.Controls.Add(this.txtPaieškaPavadinimas);
			this.Controls.Add(this.btnSukurtiKategorija);
			this.Controls.Add(this.dataGridViewKategorijos);
			this.Name = "Kategorijos";
			this.Text = "Kategorijos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewKategorijos;
		private System.Windows.Forms.Button btnSukurtiKategorija;
		private System.Windows.Forms.TextBox txtPaieškaPavadinimas;
		private System.Windows.Forms.TextBox txtPaieškaAmžiausCenzūra;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnPavadinimas;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmžiausCenzūra;
		private System.Windows.Forms.DataGridViewButtonColumn clmnPasirinkti;
		private System.Windows.Forms.DataGridViewButtonColumn clmnRedaguoti;
		private System.Windows.Forms.DataGridViewButtonColumn clmnIštrinti;
	}
}