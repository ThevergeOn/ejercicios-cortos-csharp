Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine()!);
string mensaje = edad >= 18 ? "Mayor de edad" : "Menor de edad";
Console.WriteLine(mensaje);
