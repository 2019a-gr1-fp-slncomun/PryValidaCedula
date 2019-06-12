using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppValidaCedula
{
	public partial class Principal : Form
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void AbrirArchivocedulaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ValidaCedula validaCedula = new ValidaCedula();
			validaCedula.MdiParent = this;
			validaCedula.Show();
		}

		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ValidaCedulaOtraForma validaCedula = new ValidaCedulaOtraForma();
			validaCedula.MdiParent = this;
			validaCedula.Show();
		}
	}
}
