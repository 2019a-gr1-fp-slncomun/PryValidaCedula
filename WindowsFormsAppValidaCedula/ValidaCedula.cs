using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppValidaCedula
{
	public partial class ValidaCedula : Form
	{
		public ValidaCedula()
		{
			InitializeComponent();
		}

		private void ValidaCedula_Load(object sender, EventArgs e)
		{
			//MessageBox.Show(System.Environment.CurrentDirectory);
			string cedulaLeida = string.Empty;
			string mensajeValidacionCedula = string.Empty;
			int valorRetornoCedula = 0;
			string path = System.Environment.CurrentDirectory + "\\"+ System.Configuration.ConfigurationManager.AppSettings.Get("cedulas");
			//MessageBox.Show(path);
			// Open the file to read from.
			using (StreamReader sr = File.OpenText(path))
			{
				while ((cedulaLeida = sr.ReadLine()) != null)
				{
					valorRetornoCedula = ValidaCedulaExterna(cedulaLeida, ref mensajeValidacionCedula);
					dsCedula.Tables[0].Rows.Add(new Object[] { cedulaLeida, mensajeValidacionCedula, valorRetornoCedula });
					//Console.WriteLine(s);
				}
			}
			dgvCedulas.DataSource = dsCedula.Tables[0].DefaultView;
		}
		private int ValidaCedulaExterna(string cedula, ref string mensaje)
		{
			int resultReturn = 0;
			string pathValidaCedulaExe = System.Configuration.ConfigurationManager.AppSettings.Get("pathValidaCedulaExe");
			//MessageBox.Show(pathValidaCedulaExe);
			//Programa que valida cedula de forma individual
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.CreateNoWindow = false;
			startInfo.UseShellExecute = false;
			startInfo.FileName = pathValidaCedulaExe;
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.Arguments = cedula;
			startInfo.RedirectStandardOutput = true;
			// Start the process with the info we specified.
			// Call WaitForExit and then the using statement will close.
			using (Process exeProcess = Process.Start(startInfo))
			{
				using (StreamReader reader = exeProcess.StandardOutput)
				{
					mensaje = reader.ReadToEnd();
				}
				exeProcess.WaitForExit();
				resultReturn = exeProcess.ExitCode;
			}
			return resultReturn;
		}

		private void BtnGuardarCedulasValidadas_Click(object sender, EventArgs e)
		{
			if (saveFileDialogCedula.ShowDialog() == DialogResult.OK)
			{
				using (System.IO.StreamWriter archivo = new System.IO.StreamWriter(saveFileDialogCedula.OpenFile()))
				{
					for(int i=0; i< dgvCedulas.Rows.Count;i++)
					{
						archivo.WriteLine(dgvCedulas.Rows[i].Cells[0].Value + "\t" +
										  dgvCedulas.Rows[i].Cells[1].Value + "\t" +
										  dgvCedulas.Rows[i].Cells[2].Value
							);
					}
				}
			}
		}
	}
}
