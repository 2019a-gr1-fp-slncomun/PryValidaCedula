namespace WindowsFormsAppValidaCedula
{
	partial class ValidaCedulaOtraForma
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
			if (disposing && (components != null))
			{
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvCedulas = new System.Windows.Forms.DataGridView();
			this.dsCedula = new System.Data.DataSet();
			this.dtCedula = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCedula)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCedula)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Listado de Cédulas validadas:";
			// 
			// dgvCedulas
			// 
			this.dgvCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCedulas.Location = new System.Drawing.Point(12, 48);
			this.dgvCedulas.Name = "dgvCedulas";
			this.dgvCedulas.Size = new System.Drawing.Size(776, 390);
			this.dgvCedulas.TabIndex = 2;
			// 
			// dsCedula
			// 
			this.dsCedula.DataSetName = "NewDataSet";
			this.dsCedula.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCedula});
			// 
			// dtCedula
			// 
			this.dtCedula.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
			this.dtCedula.TableName = "Table1";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "Cedula";
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "Valor";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "Mensaje";
			// 
			// ValidaCedulaOtraForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCedulas);
			this.Name = "ValidaCedulaOtraForma";
			this.Text = "ValidaCedulaOtraForma";
			this.Load += new System.EventHandler(this.ValidaCedulaOtraForma_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCedula)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCedula)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvCedulas;
		private System.Data.DataSet dsCedula;
		private System.Data.DataTable dtCedula;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
	}
}