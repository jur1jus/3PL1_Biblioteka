
namespace Presentation
{
	partial class Knyga
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
			this.txtPavadinimas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKategorija = new System.Windows.Forms.TextBox();
			this.btnKategorija = new System.Windows.Forms.Button();
			this.txtKategorijosId = new System.Windows.Forms.TextBox();
			this.btnSaugoti = new System.Windows.Forms.Button();
			this.lblIštrintiKategorija = new System.Windows.Forms.Label();
			this.txtViršelis = new System.Windows.Forms.TextBox();
			this.btnViršelis = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBoxViršelis = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxViršelis)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPavadinimas
			// 
			this.txtPavadinimas.Location = new System.Drawing.Point(104, 13);
			this.txtPavadinimas.Name = "txtPavadinimas";
			this.txtPavadinimas.Size = new System.Drawing.Size(163, 23);
			this.txtPavadinimas.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pavadinimas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kategorija:";
			// 
			// txtKategorija
			// 
			this.txtKategorija.Enabled = false;
			this.txtKategorija.Location = new System.Drawing.Point(104, 47);
			this.txtKategorija.Name = "txtKategorija";
			this.txtKategorija.Size = new System.Drawing.Size(163, 23);
			this.txtKategorija.TabIndex = 3;
			// 
			// btnKategorija
			// 
			this.btnKategorija.Location = new System.Drawing.Point(273, 47);
			this.btnKategorija.Name = "btnKategorija";
			this.btnKategorija.Size = new System.Drawing.Size(23, 23);
			this.btnKategorija.TabIndex = 4;
			this.btnKategorija.Text = "?";
			this.btnKategorija.UseVisualStyleBackColor = true;
			this.btnKategorija.Click += new System.EventHandler(this.btnKategorija_Click);
			// 
			// txtKategorijosId
			// 
			this.txtKategorijosId.Location = new System.Drawing.Point(12, 106);
			this.txtKategorijosId.Name = "txtKategorijosId";
			this.txtKategorijosId.Size = new System.Drawing.Size(10, 23);
			this.txtKategorijosId.TabIndex = 5;
			this.txtKategorijosId.Visible = false;
			// 
			// btnSaugoti
			// 
			this.btnSaugoti.Location = new System.Drawing.Point(104, 105);
			this.btnSaugoti.Name = "btnSaugoti";
			this.btnSaugoti.Size = new System.Drawing.Size(75, 23);
			this.btnSaugoti.TabIndex = 6;
			this.btnSaugoti.Text = "Saugoti";
			this.btnSaugoti.UseVisualStyleBackColor = true;
			this.btnSaugoti.Click += new System.EventHandler(this.btnSaugoti_Click);
			// 
			// lblIštrintiKategorija
			// 
			this.lblIštrintiKategorija.AutoSize = true;
			this.lblIštrintiKategorija.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblIštrintiKategorija.Location = new System.Drawing.Point(252, 48);
			this.lblIštrintiKategorija.Name = "lblIštrintiKategorija";
			this.lblIštrintiKategorija.Size = new System.Drawing.Size(14, 17);
			this.lblIštrintiKategorija.TabIndex = 7;
			this.lblIštrintiKategorija.Text = "x";
			this.lblIštrintiKategorija.Click += new System.EventHandler(this.lblIštrintiKategorija_Click);
			// 
			// txtViršelis
			// 
			this.txtViršelis.Enabled = false;
			this.txtViršelis.Location = new System.Drawing.Point(104, 76);
			this.txtViršelis.Name = "txtViršelis";
			this.txtViršelis.Size = new System.Drawing.Size(163, 23);
			this.txtViršelis.TabIndex = 8;
			// 
			// btnViršelis
			// 
			this.btnViršelis.Location = new System.Drawing.Point(271, 76);
			this.btnViršelis.Name = "btnViršelis";
			this.btnViršelis.Size = new System.Drawing.Size(26, 23);
			this.btnViršelis.TabIndex = 9;
			this.btnViršelis.Text = "...";
			this.btnViršelis.UseVisualStyleBackColor = true;
			this.btnViršelis.Click += new System.EventHandler(this.btnViršelis_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Viršelis:";
			// 
			// pictureBoxViršelis
			// 
			this.pictureBoxViršelis.Location = new System.Drawing.Point(302, 13);
			this.pictureBoxViršelis.Name = "pictureBoxViršelis";
			this.pictureBoxViršelis.Size = new System.Drawing.Size(100, 116);
			this.pictureBoxViršelis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxViršelis.TabIndex = 11;
			this.pictureBoxViršelis.TabStop = false;
			// 
			// Knyga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 333);
			this.Controls.Add(this.pictureBoxViršelis);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnViršelis);
			this.Controls.Add(this.txtViršelis);
			this.Controls.Add(this.lblIštrintiKategorija);
			this.Controls.Add(this.btnSaugoti);
			this.Controls.Add(this.txtKategorijosId);
			this.Controls.Add(this.btnKategorija);
			this.Controls.Add(this.txtKategorija);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPavadinimas);
			this.Name = "Knyga";
			this.Text = "Knyga";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxViršelis)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPavadinimas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtKategorija;
		private System.Windows.Forms.Button btnKategorija;
		private System.Windows.Forms.TextBox txtKategorijosId;
		private System.Windows.Forms.Button btnSaugoti;
		private System.Windows.Forms.Label lblIštrintiKategorija;
		private System.Windows.Forms.TextBox txtViršelis;
		private System.Windows.Forms.Button btnViršelis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBoxViršelis;
	}
}