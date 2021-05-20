
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
			// 
			// txtKategorijosId
			// 
			this.txtKategorijosId.Location = new System.Drawing.Point(302, 47);
			this.txtKategorijosId.Name = "txtKategorijosId";
			this.txtKategorijosId.Size = new System.Drawing.Size(10, 23);
			this.txtKategorijosId.TabIndex = 5;
			// 
			// btnSaugoti
			// 
			this.btnSaugoti.Location = new System.Drawing.Point(104, 107);
			this.btnSaugoti.Name = "btnSaugoti";
			this.btnSaugoti.Size = new System.Drawing.Size(75, 23);
			this.btnSaugoti.TabIndex = 6;
			this.btnSaugoti.Text = "Saugoti";
			this.btnSaugoti.UseVisualStyleBackColor = true;
			// 
			// Knyga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 333);
			this.Controls.Add(this.btnSaugoti);
			this.Controls.Add(this.txtKategorijosId);
			this.Controls.Add(this.btnKategorija);
			this.Controls.Add(this.txtKategorija);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPavadinimas);
			this.Name = "Knyga";
			this.Text = "Knyga";
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
	}
}