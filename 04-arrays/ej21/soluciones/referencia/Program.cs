int[,] m =
{
    {  1,  2,  3,  0,  0 },
    { 11, 12,  0,  0,  0 },
    {  0,  0,  0,  0,  0 },
    { 41, 42, 43, 44, 45 },
    { 51,  0,  0,  0,  0 },
    { 61, 62,  0,  0,  0 }
};
ImprimeDentada(MatrizADentada(m));   // [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]]

static int[]?[] MatrizADentada(int[,] m)
{
    int filas = m.GetLength(0), cols = m.GetLength(1);
    int[]?[] td = new int[filas][];
    for (int f = 0; f < filas; f++)
    {
        int longitud = cols;
        while (longitud > 0 && m[f, longitud - 1] == 0)   // quitar ceros del final
            longitud--;

        if (longitud == 0)
            td[f] = null;
        else
        {
            int[] fila = new int[longitud];
            for (int c = 0; c < longitud; c++)
                fila[c] = m[f, c];
            td[f] = fila;
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
