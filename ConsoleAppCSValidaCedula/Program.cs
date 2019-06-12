using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSValidaCedula
{
	class Program
	{
		static void Main(string[] args)
		{
			//Programa que valida cedula de forma individual
			int resultReturn = 0;
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.CreateNoWindow = false;
			startInfo.UseShellExecute = false;
			startInfo.FileName = @"..\..\..\debug\ConsoleAppValidaCedula.exe";
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;
			startInfo.Arguments = "0100432517";
			startInfo.RedirectStandardOutput = true;
			// Start the process with the info we specified.
			// Call WaitForExit and then the using statement will close.
			using (Process exeProcess = Process.Start(startInfo))
			{
				using (StreamReader reader = exeProcess.StandardOutput)
				{
					string result = reader.ReadToEnd();
					Console.WriteLine(result);
				}
				exeProcess.WaitForExit();
				resultReturn = exeProcess.ExitCode;
				Console.WriteLine("Codigo retorno leido es: " + resultReturn);
			}
			Console.ReadKey();
		}	
	}
}
