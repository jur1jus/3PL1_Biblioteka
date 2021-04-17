
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
			this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnPavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnAmžiausCenzūra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSukurtiKategorija = new System.Windows.Forms.Button();
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
            this.clmnAmžiausCenzūra});
			this.dataGridViewKategorijos.Location = new System.Drawing.Point(-1, 51);
			this.dataGridViewKategorijos.Name = "dataGridViewKategorijos";
			this.dataGridViewKategorijos.ReadOnly = true;
			this.dataGridViewKategorijos.RowTemplate.Height = 25;
			this.dataGridViewKategorijos.Size = new System.Drawing.Size(489, 296);
			this.dataGridViewKategorijos.TabIndex = 0;
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
			// btnSukurtiKategorija
			// 
			this.btnSukurtiKategorija.Location = new System.Drawing.Point(356, 12);
			this.btnSukurtiKategorija.Name = "btnSukurtiKategorija";
			this.btnSukurtiKategorija.Size = new System.Drawing.Size(120, 23);
			this.btnSukurtiKategorija.TabIndex = 1;
			this.btnSukurtiKategorija.Text = "Sukurti kategorija";
			this.btnSukurtiKategorija.UseVisualStyleBackColor = true;
			this.btnSukurtiKategorija.Click += new System.EventHandler(this.btnSukurtiKategorija_Click);
			// 
			// Kategorijos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 346);
			this.Controls.Add(this.btnSukurtiKategorija);
			this.Controls.Add(this.dataGridViewKategorijos);
			this.Name = "Kategorijos";
			this.Text = "Kategorijos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorijos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewKategorijos;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnPavadinimas;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmžiausCenzūra;
		private System.Windows.Forms.Button btnSukurtiKategorija;
	}
}