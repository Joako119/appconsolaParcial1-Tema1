// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double contador, area,bases,altura , volumen, radio;
bool salir;
contador = 0;
salir = true;
do

{


	try
	{
		radio = PedirDouble ("Ingresar el radio del cilindro o si se desea salir ingresar cero:  ");
		
		altura= PedirDouble ("Ingresa la altura del cilindro o si se desea salir ingresar cero:  ");

		if (radio > 0 && altura > 0)
		{
			area = 2 * Math.PI * radio * (altura + radio);
			bases = Math.PI * radio * radio;
			volumen = bases * altura;
			contador++;

			Console.WriteLine($" El valor del area del {contador} cilindro es,  {area},  la base del mismo es {bases}  y su voumen es {volumen}");

			
		}
		else if (radio == 0 && altura == 0) { salir = false; }
		else Console.WriteLine("Los datos a ingresar deben ser mayores a 0");

	}
	catch (FormatException ){ Console.WriteLine("Error por favor verificar el fomato ingresado"); }
	catch (OverflowException ) { Console.WriteLine("Valores ingresados muy grasden"); }
}
	while (salir);
 static double PedirDouble(string Mensaje)
{
	double nro = 0;
	do
	{
		Console.Write(Mensaje);
		string strConsola = Console.ReadLine();
		if (!double.TryParse(strConsola, out nro))
		{
			Console.WriteLine("Número mal ingresado");

		}
		else
		{
			break;
		}

	} while (true);
	return nro;
}





Console.WriteLine( "Gracias");




