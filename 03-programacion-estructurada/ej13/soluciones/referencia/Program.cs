Console.Write("n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Suma: {SumaPrimerosNumeros(n)}");

static int SumaPrimerosNumeros(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
        suma += i;
    return suma;
}
