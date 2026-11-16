int[]?[] td = [[1, 2, 3], [11, 12], null, [41, 42, 43, 44, 45], [51], [61, 62]];
ImprimeDentada(Traspone(td));   // [[1, 11, 41, 51, 61], [2, 12, 42, 62], [3, 43], [44], [45]]

static int[]?[] Traspone(int[]?[] td)
{
    int maxLong = 0;
    foreach (int[]? fila in td)
        if (fila != null && fila.Length > maxLong)
            maxLong = fila.Length;

    int[]?[] r = new int[maxLong][];
    for (int j = 0; j < maxLong; j++)
    {
        int[] nueva = [];
        foreach (int[]? fila in td)
            if (fila != null && j < fila.Length)
                nueva = [.. nueva, fila[j]];
        r[j] = nueva;
    }
    return r;
}

static void ImprimeDentada(int[]?[] td)
{
    string[] filas = new string[td.Length];
    for (int i = 0; i < td.Length; i++)
        filas[i] = td[i] == null ? "NULL" : $"[{string.Join(", ", td[i]!)}]";
    Console.WriteLine($"[{string.Join(", ", filas)}]");
}
