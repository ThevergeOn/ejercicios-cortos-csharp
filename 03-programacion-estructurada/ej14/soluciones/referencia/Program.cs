Console.Write("n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Suma: {SumaPrimerosPrimos(n)}");

static int SumaPrimerosPrimos(int n)
{
    int suma = 0, encontrados = 0, candidato = 2;
    while (encontrados < n)
    {
        if (EsPrimo(candidato))
        {
            suma += candidato;
            encontrados++;
        }
        candidato++;
    }
    return suma;
}

static bool EsPrimo(int n)
{
    bool esPrimo = n > 1;
    for (int i = 2; esPrimo && i < n; i++)
        if (n % i == 0)
            esPrimo = false;
    return esPrimo;
}
