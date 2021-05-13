
namespace Presentation
{
	partial class Knygos
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnPavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnAutorius = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnMetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnKategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnPavadinimas,
            this.clmnAutorius,
            this.clmnMetai,
            this.clmnKategorija});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 83);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(444, 225);
			this.dataGridView1.TabIndex = 0;
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
			// 
			// clmnAutorius
			// 
			this.clmnAutorius.HeaderText = "Autorius";
			this.clmnAutorius.Name = "clmnAutorius";
			this.clmnAutorius.ReadOnly = true;
			// 
			// clmnMetai
			// 
			this.clmnMetai.HeaderText = "Metai";
			this.clmnMetai.Name = "clmnMetai";
			this.clmnMetai.ReadOnly = true;
			// 
			// clmnKategorija
			// 
			this.clmnKategorija.HeaderText = "Kategorija";
			this.clmnKategorija.Name = "clmnKategorija";
			this.clmnKategorija.ReadOnly = true;
			// 
			// Knygos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 308);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Knygos";
			this.Text = "Knygos";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnPavadinimas;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnAutorius;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnMetai;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnKategorija;
	}
}