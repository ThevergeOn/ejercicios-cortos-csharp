int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
ImprimeMatriz(ConSumas(m));

static int[,] ConSumas(int[,] m)
{
    int filas = m.GetLength(0), cols = m.GetLength(1);
    int[,] r = new int[filas + 1, cols + 1];
    for (int f = 0; f < filas; f++)
        for (int c = 0; c < cols; c++)
        {
            r[f, c] = m[f, c];
            r[f, cols] += m[f, c];        // suma de la fila
            r[filas, c] += m[f, c];       // suma de la columna
            r[filas, cols] += m[f, c];    // suma total
        }
    return r;
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
