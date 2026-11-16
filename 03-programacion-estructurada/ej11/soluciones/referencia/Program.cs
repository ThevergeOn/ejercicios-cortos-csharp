Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Primos: {PrimosEnIntervalo(a, b)}");

static string PrimosEnIntervalo(int a, int b)
{
    string salida = "";
    for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        if (EsPrimo(i))
            salida += $"{i} ";
    return salida;
}

static bool EsPrimo(int n)
{
    bool esPrimo = n > 1;
    for (int i = 2; esPrimo && i < n; i++)
        if (n % i == 0)
            esPrimo = false;
    return esPrimo;
}
