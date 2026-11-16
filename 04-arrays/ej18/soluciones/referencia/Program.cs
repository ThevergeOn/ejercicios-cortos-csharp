int[]?[] td = [[1, 2, 3], [11, 12], null, [41, 42, 43, 44, 45], [51], [61, 62]];
ImprimeDentada(InvierteTodo(td));   // [[62, 61], [51], [45, 44, 43, 42, 41], NULL, [12, 11], [3, 2, 1]]

static int[] Invierte(int[] v)
{
    int[] r = new int[v.Length];
    for (int i = 0; i < v.Length; i++)
        r[i] = v[v.Length - 1 - i];
    return r;
}

static int[]?[] InvierteTodo(int[]?[] td)
{
    int[]?[] r = new int[td.Length][];
    for (int i = 0; i < td.Length; i++)
    {
        int[]? fila = td[td.Length - 1 - i];
        r[i] = fila == null ? null : Invierte(fila);
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
