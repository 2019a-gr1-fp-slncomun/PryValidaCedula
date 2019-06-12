#include <string.h> 
#include <iostream>
#include <stdlib.h>
using namespace std;
bool ValidarTamanio(string cedula) 
{
	if (cedula.size() != 10) 
	{
		return false;
	}
	return true;
}
bool ValidaSoloNumeros(string cedula) 
{
	for (int n = 0; n < (int)cedula.length(); n++) 
	{
		if (!((cedula[n] >= '0' && cedula[n] <= '9'))) 
		{
			return false;
		}
	}
	return true;
}
bool ValidaTercerDigito(string cedula) {
	if (cedula[2] < '0' || cedula[2] > '6') 
	{
		return false;
	}
	return true;
}
int ValidaProvinciaCedula(string cedula) 
{
	string provincia = cedula.substr(0, 2);
	int codigoProvincia = atoi(provincia.c_str());
	if (codigoProvincia <= 0 || codigoProvincia > 24) 
	{
		return false;
	}
	return true;
}
bool ValidaDigitoVerificador(string cedula)
{
	int sumaPares = 0, sumaImpares = 0, sumaTotal = 0, valorPar = 1, digitoCalculado = 0;
	int numerosC[10] = {0};//int* numerosC = new int[10];
	for (int i = 0; i < (int)cedula.size(); i++)
	{
		numerosC[i] = (int)cedula[i] - 48;
	}
	//suma pares e impares (con multiplicación y validación ), se descarta ultimo digito
	for (int i = 0; i < sizeof(numerosC) / sizeof(numerosC[0]) - 1; i++) 
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
	if (digitoCalculado == numerosC[cedula.size() - 1]) 
	{
		return true;//cedula valida
	}
	else 
	{
		return false;//cedula no valida
	}

}
int main(int argc, char** argv) 
{
	setlocale(LC_ALL, "");
	if (argc < 2) 
	{
		cerr << "La cédula debe venir como parámetro por la línea de comandos para: " << argv[0];
		return 1;
	}
	string cedula = argv[1];
	if (!ValidarTamanio(cedula)) {
		cout << "Tamaño cédula " << cedula << " no válido!!";
		return 1;
	}
	if (!ValidaSoloNumeros(cedula)) {
		cout << "Cédula " << cedula << " solo debe tener números!!";
		return 2;
	}
	if (!ValidaTercerDigito(cedula)) {
		cout << "Tercer dígito de cédula " << cedula << " es INVÁLIDO!!";
		return 3;
	}
	if (!ValidaProvinciaCedula(cedula)) {
		cout << "Cédula " << cedula << " no fue emitida para una provincia válida!!";
		return 4;
	}
	if (ValidaDigitoVerificador(cedula)) {
		cout << "Cédula " << cedula << " es Válida!!";
	}
	else {
		cout << "Cédula " << cedula << " es INVÁLIDA!!";
		return 5;
	}
	return 0;
}

