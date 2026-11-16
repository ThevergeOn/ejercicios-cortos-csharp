Console.Write("Primer número: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
int b = int.Parse(Console.ReadLine()!);

string relacion = a > b ? "mayor que" : a < b ? "menor que" : "igual que";
Console.WriteLine($"{a} es {relacion} {b}");
