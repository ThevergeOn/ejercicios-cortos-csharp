Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Suma de impares: {SumaImpares(a, b)}");

static int SumaImpares(int a, int b)
{
    int suma = 0;
    for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        if (i % 2 != 0)
            suma += i;
    return suma;
}
