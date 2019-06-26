using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppValidaCedula
{
	public partial class ValidaCedulaOtraForma : Form
	{
		public ValidaCedulaOtraForma()
		{
			InitializeComponent();
		}

		private void ValidaCedulaOtraForma_Load(object sender, EventArgs e)
		{
			//MessageBox.Show(System.Environment.CurrentDirectory);
			string cedulaLeida = string.Empty;
			string mensajeValidacionCedula = string.Empty;
			int valorRetornoCedula = 0;
			ClassLibraryValidaCedula.ClassValidaCedula validaCedulaExternaClass = new ClassLibraryValidaCedula.ClassValidaCedula();
			string path = System.Environment.CurrentDirectory + "\\" + System.Configuration.ConfigurationManager.AppSettings.Get("cedulas");
			//MessageBox.Show(path);
			// Open the file to read from.
			using (StreamReader sr = File.OpenText(path))
			{
				while ((cedulaLeida = sr.ReadLine()) != null)
				{
					valorRetornoCedula = validaCedulaExternaClass.ValidaCedula(cedulaLeida, ref mensajeValidacionCedula);
					//object[,] objects = new object[1, 3];
					//objects[0, 1] = cedulaLeida;
					dsCedula.Tables[0].Rows.Add(new Object[] { cedulaLeida, mensajeValidacionCedula, valorRetornoCedula });
					//dsCedula.Tables[0]
					//Console.WriteLine(s);
				}
			}
			dgvCedulas.DataSource = dsCedula.Tables[0].DefaultView;
		}
	}
}
