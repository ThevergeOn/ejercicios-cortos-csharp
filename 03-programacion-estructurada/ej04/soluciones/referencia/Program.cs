Console.Write("Dividendo: ");
int dividendo = int.Parse(Console.ReadLine()!);
Console.Write("Divisor: ");
int divisor = int.Parse(Console.ReadLine()!);
(int cociente, int resto) = Divide(dividendo, divisor);
Console.WriteLine($"Cociente: {cociente}  Resto: {resto}");

static (int cociente, int resto) Divide(int dividendo, int divisor)
{
    int cociente = 0;
    while (dividendo >= divisor)
    {
        dividendo -= divisor;
        cociente++;
    }
    return (cociente, dividendo);
}
