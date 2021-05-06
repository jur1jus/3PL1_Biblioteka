
namespace Presentation
{
	partial class KlientoRegistracija
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
			this.txtVardas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPavardė = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtElPaštas = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtKortelėsId = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegistruoti = new System.Windows.Forms.Button();
			this.btnGeneruoti = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtVardas
			// 
			this.txtVardas.Location = new System.Drawing.Point(88, 21);
			this.txtVardas.Name = "txtVardas";
			this.txtVardas.Size = new System.Drawing.Size(148, 23);
			this.txtVardas.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vardas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Pavardė";
			// 
			// txtPavardė
			// 
			this.txtPavardė.Location = new System.Drawing.Point(88, 50);
			this.txtPavardė.Name = "txtPavardė";
			this.txtPavardė.Size = new System.Drawing.Size(148, 23);
			this.txtPavardė.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "El. paštas";
			// 
			// txtElPaštas
			// 
			this.txtElPaštas.Location = new System.Drawing.Point(88, 79);
			this.txtElPaštas.Name = "txtElPaštas";
			this.txtElPaštas.Size = new System.Drawing.Size(148, 23);
			this.txtElPaštas.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(271, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txtKortelėsId
			// 
			this.txtKortelėsId.Enabled = false;
			this.txtKortelėsId.Location = new System.Drawing.Point(88, 108);
			this.txtKortelėsId.Name = "txtKortelėsId";
			this.txtKortelėsId.Size = new System.Drawing.Size(148, 23);
			this.txtKortelėsId.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Kortelės ID";
			// 
			// btnRegistruoti
			// 
			this.btnRegistruoti.Location = new System.Drawing.Point(88, 198);
			this.btnRegistruoti.Name = "btnRegistruoti";
			this.btnRegistruoti.Size = new System.Drawing.Size(148, 23);
			this.btnRegistruoti.TabIndex = 9;
			this.btnRegistruoti.Text = "Registruoti";
			this.btnRegistruoti.UseVisualStyleBackColor = true;
			this.btnRegistruoti.Click += new System.EventHandler(this.btnRegistruoti_Click);
			// 
			// btnGeneruoti
			// 
			this.btnGeneruoti.Location = new System.Drawing.Point(88, 138);
			this.btnGeneruoti.Name = "btnGeneruoti";
			this.btnGeneruoti.Size = new System.Drawing.Size(148, 23);
			this.btnGeneruoti.TabIndex = 10;
			this.btnGeneruoti.Text = "Generuoti";
			this.btnGeneruoti.UseVisualStyleBackColor = true;
			this.btnGeneruoti.Click += new System.EventHandler(this.btnGeneruoti_Click);
			// 
			// KlientoRegistracija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 238);
			this.Controls.Add(this.btnGeneruoti);
			this.Controls.Add(this.btnRegistruoti);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtKortelėsId);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtElPaštas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPavardė);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtVardas);
			this.Name = "KlientoRegistracija";
			this.Text = "KlientoRegistracija";
			this.Load += new System.EventHandler(this.KlientoRegistracija_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtVardas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPavardė;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtElPaštas;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtKortelėsId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRegistruoti;
		private System.Windows.Forms.Button btnGeneruoti;
	}
}