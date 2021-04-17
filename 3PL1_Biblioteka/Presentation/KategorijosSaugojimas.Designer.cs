
namespace Presentation
{
	partial class KategorijosSaugojimas
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
			this.btnSaugoti = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPavadinimas = new System.Windows.Forms.TextBox();
			this.txtAmžiausCenzūra = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSaugoti
			// 
			this.btnSaugoti.Location = new System.Drawing.Point(113, 67);
			this.btnSaugoti.Name = "btnSaugoti";
			this.btnSaugoti.Size = new System.Drawing.Size(75, 23);
			this.btnSaugoti.TabIndex = 0;
			this.btnSaugoti.Text = "Saugoti";
			this.btnSaugoti.UseVisualStyleBackColor = true;
			this.btnSaugoti.Click += new System.EventHandler(this.btnSaugoti_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pavadinimas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Amžiaus cenzūra";
			// 
			// txtPavadinimas
			// 
			this.txtPavadinimas.Location = new System.Drawing.Point(113, 13);
			this.txtPavadinimas.Name = "txtPavadinimas";
			this.txtPavadinimas.Size = new System.Drawing.Size(130, 23);
			this.txtPavadinimas.TabIndex = 3;
			// 
			// txtAmžiausCenzūra
			// 
			this.txtAmžiausCenzūra.Location = new System.Drawing.Point(113, 38);
			this.txtAmžiausCenzūra.Name = "txtAmžiausCenzūra";
			this.txtAmžiausCenzūra.Size = new System.Drawing.Size(130, 23);
			this.txtAmžiausCenzūra.TabIndex = 4;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(250, 13);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(16, 23);
			this.txtId.TabIndex = 5;
			// 
			// KategorijosSaugojimas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 105);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtAmžiausCenzūra);
			this.Controls.Add(this.txtPavadinimas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSaugoti);
			this.Name = "KategorijosSaugojimas";
			this.Text = "KategorijosSaugojimas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaugoti;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPavadinimas;
		private System.Windows.Forms.TextBox txtAmžiausCenzūra;
		private System.Windows.Forms.TextBox txtId;
	}
}