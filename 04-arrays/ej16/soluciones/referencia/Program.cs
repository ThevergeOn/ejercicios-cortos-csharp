int[]?[] td = Dentada([3, 1, 0, 5, 2]);
ImprimeDentada(td);   // [[3, 3, 3], [1], NULL, [5, 5, 5, 5, 5], [2, 2]]

static int[]?[] Dentada(int[] v)
{
    int[]?[] td = new int[v.Length][];
    for (int i = 0; i < v.Length; i++)
    {
        if (v[i] == 0)
            td[i] = null;
        else
        {
            int[] fila = new int[v[i]];
            for (int k = 0; k < fila.Length; k++)
                fila[k] = v[i];
            td[i] = fila;
        }
    }
    return td;
}

static void ImprimeDentada(int[]?[] td)
{
    string[] filas = new string[td.Length];
    for (int i = 0; i < td.Length; i++)
        filas[i] = td[i] == null ? "NULL" : $"[{string.Join(", ", td[i]!)}]";
    Console.WriteLine($"[{string.Join(", ", filas)}]");
}
