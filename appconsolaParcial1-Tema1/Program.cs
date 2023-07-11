// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double contador, area,bases,altura , volumen, radio;

do

{
	Console.WriteLine("Ingresar el radio del cilindro o si se desea salir ingresar cero");
	radio= int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa la altura del cilindro o si se desea salir ingresar cero");
	altura= int.Parse(Console.ReadLine());

	area = 2 * Math.PI * radio * (altura + radio);
	bases = Math.PI * radio  * radio;
	volumen = bases * altura;

}

while (bases==0 && altura==0);








