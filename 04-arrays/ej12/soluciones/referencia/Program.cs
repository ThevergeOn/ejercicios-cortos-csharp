Console.WriteLine(SumaDigitosArray([3, 11, 0, 52]));   // 12

static int SumaDigitos(int n)
{
    int suma = 0;
    while (n > 0)
    {
        suma += n % 10;
        n /= 10;
    }
    return suma;
}

static int SumaDigitosArray(int[] v)
{
    int total = 0;
    foreach (int n in v)
        total += SumaDigitos(n);
    return total;
}
