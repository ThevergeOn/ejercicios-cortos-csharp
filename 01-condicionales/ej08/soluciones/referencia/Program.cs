Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine()!);
int precio = edad < 12 ? 5 : 10;
Console.WriteLine($"Precio de la entrada: {precio} €");
