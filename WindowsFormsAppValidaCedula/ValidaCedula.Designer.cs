namespace WindowsFormsAppValidaCedula
{
	partial class ValidaCedula
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
			this.dgvCedulas = new System.Windows.Forms.DataGridView();
			this.dsCedula = new System.Data.DataSet();
			this.dtCedula = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardarCedulasValidadas = new System.Windows.Forms.Button();
			this.saveFileDialogCedula = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCedula)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCedula)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCedulas
			// 
			this.dgvCedulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCedulas.Location = new System.Drawing.Point(12, 48);
			this.dgvCedulas.Name = "dgvCedulas";
			this.dgvCedulas.Size = new System.Drawing.Size(776, 390);
			this.dgvCedulas.TabIndex = 0;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listado de Cédulas validadas:";
			// 
			// btnGuardarCedulasValidadas
			// 
			this.btnGuardarCedulasValidadas.Location = new System.Drawing.Point(605, 446);
			this.btnGuardarCedulasValidadas.Name = "btnGuardarCedulasValidadas";
			this.btnGuardarCedulasValidadas.Size = new System.Drawing.Size(182, 38);
			this.btnGuardarCedulasValidadas.TabIndex = 2;
			this.btnGuardarCedulasValidadas.Text = "Guardar archivo";
			this.btnGuardarCedulasValidadas.UseVisualStyleBackColor = true;
			this.btnGuardarCedulasValidadas.Click += new System.EventHandler(this.BtnGuardarCedulasValidadas_Click);
			// 
			// saveFileDialogCedula
			// 
			this.saveFileDialogCedula.DefaultExt = "txt";
			this.saveFileDialogCedula.FileName = "CedulasValidadas.txt";
			this.saveFileDialogCedula.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			this.saveFileDialogCedula.RestoreDirectory = true;
			// 
			// ValidaCedula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 499);
			this.Controls.Add(this.btnGuardarCedulasValidadas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCedulas);
			this.Name = "ValidaCedula";
			this.Text = "Validador de Cédulas";
			this.Load += new System.EventHandler(this.ValidaCedula_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCedulas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCedula)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtCedula)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCedulas;
		private System.Data.DataSet dsCedula;
		private System.Data.DataTable dtCedula;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuardarCedulasValidadas;
		private System.Windows.Forms.SaveFileDialog saveFileDialogCedula;
	}
}