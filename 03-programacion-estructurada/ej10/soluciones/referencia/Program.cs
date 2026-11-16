Console.Write("Número: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(EsPrimo(n) ? "Es primo" : "No es primo");

static bool EsPrimo(int n)
{
    bool esPrimo = n > 1;
    for (int i = 2; esPrimo && i < n; i++)
        if (n % i == 0)
            esPrimo = false;
    return esPrimo;
}
