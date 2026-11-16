Console.WriteLine(CuantosPares([3, 1, 0, 5, 2]));   // 2

static int CuantosPares(int[] v)
{
    int contador = 0;
    foreach (int n in v)
        if (n % 2 == 0)
            contador++;
    return contador;
}
