int[]?[] td = [[1, 2, 3], [11, 12], null, [41, 42, 43, 44, 45], [51], [61, 62]];
ImprimeMatriz(DentadaAMatriz(td));

static int[,] DentadaAMatriz(int[]?[] td)
{
    int cols = 0;
    foreach (int[]? fila in td)
        if (fila != null && fila.Length > cols)
            cols = fila.Length;

    int[,] m = new int[td.Length, cols];          // todo a 0
    for (int f = 0; f < td.Length; f++)
        if (td[f] != null)
            for (int c = 0; c < td[f]!.Length; c++)
                m[f, c] = td[f]![c];
    return m;
}

static void ImprimeMatriz(int[,] m)
{
    for (int f = 0; f < m.GetLength(0); f++)
    {
        Console.Write("[");
        for (int c = 0; c < m.GetLength(1); c++)
            Console.Write(c == 0 ? $"{m[f, c],2}" : $", {m[f, c],2}");
        Console.WriteLine("]");
    }
}
