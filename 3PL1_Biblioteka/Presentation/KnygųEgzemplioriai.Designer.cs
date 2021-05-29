
namespace Presentation
{
	partial class KnygųEgzemplioriai
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnNumeris = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnSekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmnLentyna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(61, 10);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(201, 23);
			this.comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Knyga:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnNumeris,
            this.clmnSekcija,
            this.clmnLentyna});
			this.dataGridView1.Location = new System.Drawing.Point(12, 42);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(365, 150);
			this.dataGridView1.TabIndex = 2;
			// 
			// clmnId
			// 
			this.clmnId.HeaderText = "";
			this.clmnId.Name = "clmnId";
			this.clmnId.ReadOnly = true;
			this.clmnId.Visible = false;
			// 
			// clmnNumeris
			// 
			this.clmnNumeris.HeaderText = "Numeris";
			this.clmnNumeris.Name = "clmnNumeris";
			this.clmnNumeris.ReadOnly = true;
			// 
			// clmnSekcija
			// 
			this.clmnSekcija.HeaderText = "Sekcija";
			this.clmnSekcija.Name = "clmnSekcija";
			this.clmnSekcija.ReadOnly = true;
			// 
			// clmnLentyna
			// 
			this.clmnLentyna.HeaderText = "Lentyna";
			this.clmnLentyna.Name = "clmnLentyna";
			this.clmnLentyna.ReadOnly = true;
			// 
			// KnygųEgzemplioriai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 209);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "KnygųEgzemplioriai";
			this.Text = "KnygųEgzemplioriai";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumeris;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnSekcija;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmnLentyna;
	}
}