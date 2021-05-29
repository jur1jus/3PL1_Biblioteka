
namespace Presentation
{
	partial class EgzemplioriųGeneravimas
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
			this.txtSekcija = new System.Windows.Forms.TextBox();
			this.txtLentyna = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGeneruoti = new System.Windows.Forms.Button();
			this.txtEgzemplioriųSkaičius = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtSekcija
			// 
			this.txtSekcija.Location = new System.Drawing.Point(140, 35);
			this.txtSekcija.Name = "txtSekcija";
			this.txtSekcija.Size = new System.Drawing.Size(100, 23);
			this.txtSekcija.TabIndex = 0;
			// 
			// txtLentyna
			// 
			this.txtLentyna.Location = new System.Drawing.Point(140, 64);
			this.txtLentyna.Name = "txtLentyna";
			this.txtLentyna.Size = new System.Drawing.Size(100, 23);
			this.txtLentyna.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(88, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Sekcija:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lentyna:";
			// 
			// btnGeneruoti
			// 
			this.btnGeneruoti.Location = new System.Drawing.Point(12, 93);
			this.btnGeneruoti.Name = "btnGeneruoti";
			this.btnGeneruoti.Size = new System.Drawing.Size(229, 23);
			this.btnGeneruoti.TabIndex = 4;
			this.btnGeneruoti.Text = "Generuoti";
			this.btnGeneruoti.UseVisualStyleBackColor = true;
			this.btnGeneruoti.Click += new System.EventHandler(this.btnGeneruoti_Click);
			// 
			// txtEgzemplioriųSkaičius
			// 
			this.txtEgzemplioriųSkaičius.Location = new System.Drawing.Point(140, 8);
			this.txtEgzemplioriųSkaičius.Name = "txtEgzemplioriųSkaičius";
			this.txtEgzemplioriųSkaičius.Size = new System.Drawing.Size(100, 23);
			this.txtEgzemplioriųSkaičius.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Egzempliorių skaičius:";
			// 
			// EgzemplioriųGeneravimas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 126);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEgzemplioriųSkaičius);
			this.Controls.Add(this.btnGeneruoti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLentyna);
			this.Controls.Add(this.txtSekcija);
			this.Name = "EgzemplioriųGeneravimas";
			this.Text = "EgzemplioriųGeneravimas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSekcija;
		private System.Windows.Forms.TextBox txtLentyna;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGeneruoti;
		private System.Windows.Forms.TextBox txtEgzemplioriųSkaičius;
		private System.Windows.Forms.Label label3;
	}
}