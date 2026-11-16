Console.WriteLine(CuantasVeces([4, 7, 4, 1, 4, 9], 4));   // 3

static int CuantasVeces(int[] v, int buscado)
{
    int contador = 0;
    foreach (int n in v)
        if (n == buscado)
            contador++;
    return contador;
}
