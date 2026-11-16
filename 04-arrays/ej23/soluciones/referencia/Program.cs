Console.WriteLine(string.Join(", ", Criba(30)));   // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29

static int[] Criba(int n)
{
    bool[] tachado = new bool[n + 1];          // todo a false
    for (int i = 2; i * i <= n; i++)
        if (!tachado[i])
            for (int multiplo = i * i; multiplo <= n; multiplo += i)
                tachado[multiplo] = true;

    int[] primos = [];
    for (int i = 2; i <= n; i++)
        if (!tachado[i])
            primos = [.. primos, i];
    return primos;
}
