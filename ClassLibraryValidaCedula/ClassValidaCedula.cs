using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryValidaCedula
{
    public class ClassValidaCedula
    {
		bool ValidarTamanio(string cedula)
		{
			if (cedula.Length != 10)
			{
				return false;
			}
			return true;
		}
		bool ValidaSoloNumeros(string cedula)
		{
			for (int n = 0; n < (int)cedula.Length; n++)
			{
				if (!((cedula[n] >= '0' && cedula[n] <= '9')))
				{
					return false;
				}
			}
			return true;
		}
		bool ValidaTercerDigito(string cedula)
		{
			if (cedula[2] < '0' || cedula[2] > '6')
			{
				return false;
			}
			return true;
		}
		bool ValidaProvinciaCedula(string cedula)
		{
			string provincia = cedula.Substring(0, 2);
			int codigoProvincia = Convert.ToInt32(provincia);
			if (codigoProvincia <= 0 || codigoProvincia > 24)
			{
				return false;
			}
			return true;
		}
		bool ValidaDigitoVerificador(string cedula)
		{
			int sumaPares = 0, sumaImpares = 0, sumaTotal = 0, valorPar = 1, digitoCalculado = 0;
			int[] numerosC = new int[cedula.Length];
			for (int i = 0; i < (int)cedula.Length; i++)
			{
				numerosC[i] = (int)cedula[i] - 48;
			}
			//suma pares e impares (con multiplicación y validación ), se descarta ultimo digito
			for (int i = 0; i < numerosC.Length - 1; i++)
			{
				if (!(i % 2 == 0))
				{//suma solo impares
					sumaImpares += numerosC[i];
				}
				else
				{//para impares multiplica por 2 y suma.
					valorPar = numerosC[i] * 2;//multiplica x 2
					if (valorPar >= 10)
					{ //si es mayor a 10 le resta 9
						valorPar -= 9;
					}
					sumaPares += valorPar;
				}
			}
			sumaTotal = sumaPares + sumaImpares;
			digitoCalculado = sumaTotal * 9 % 10;
			if (digitoCalculado == 10)
			{//si dígito es 10 entonces es 0
				digitoCalculado = 0;
			}
			if (digitoCalculado == numerosC[cedula.Length - 1])
			{
				return true;//cedula valida
			}
			else
			{
				return false;//cedula no valida
			}

		}
		public int ValidaCedula(string cedula, ref string mensajeValidacion)
		{
			if (!ValidarTamanio(cedula))
			{
				mensajeValidacion = "Tamaño cédula " + cedula + " no válido!!";
				return 1;
			}
			if (!ValidaSoloNumeros(cedula))
			{
				mensajeValidacion = "Cédula " + cedula + " solo debe tener números!!";
				return 2;
			}
			if (!ValidaTercerDigito(cedula))
			{
				mensajeValidacion = "Tercer dígito de cédula " + cedula + " es INVÁLIDO!!";
				return 3;
			}
			if (!ValidaProvinciaCedula(cedula))
			{
				mensajeValidacion = "Cédula " + cedula + " no fue emitida para una provincia válida!!";
				return 4;
			}
			if (ValidaDigitoVerificador(cedula))
			{
				mensajeValidacion = "Cédula " + cedula + " es Válida!!";
				return 0;
			}
			else
			{
				mensajeValidacion = "Cédula " + cedula + " es INVÁLIDA!!";
				return 5;
			}
			return 0;
		}
	}
}
