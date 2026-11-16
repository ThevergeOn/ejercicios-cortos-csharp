Console.Write("Lado 1: ");
double l1 = double.Parse(Console.ReadLine()!);
Console.Write("Lado 2: ");
double l2 = double.Parse(Console.ReadLine()!);
Console.Write("Lado 3: ");
double l3 = double.Parse(Console.ReadLine()!);

bool existe = l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1;
string tipo;
if (!existe)
    tipo = "No forman un triángulo";
else if (l1 == l2 && l2 == l3)
    tipo = "Equilátero";
else if (l1 == l2 || l1 == l3 || l2 == l3)
    tipo = "Isósceles";
else
    tipo = "Escaleno";
Console.WriteLine(tipo);
