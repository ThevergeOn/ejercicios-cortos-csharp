Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Número 3: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine($"El del medio es {Medio(a, b, c)}");

static int Medio(int a, int b, int c)
{
    int mayor = Math.Max(a, Math.Max(b, c));
    int menor = Math.Min(a, Math.Min(b, c));
    return a + b + c - mayor - menor;
}
