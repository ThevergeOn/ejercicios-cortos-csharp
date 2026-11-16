Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Número 3: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine(EstanOrdenados(a, b, c) ? "Están ordenados" : "No están ordenados");

static bool EstanOrdenados(int a, int b, int c) => a <= b && b <= c;
