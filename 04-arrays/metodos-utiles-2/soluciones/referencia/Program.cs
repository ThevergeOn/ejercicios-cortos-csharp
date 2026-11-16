int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
ImprimeMatriz(m);

static void ImprimeMatriz(int[,] m)
{
    for (int f = 0; f < m.GetLength(0); f++)
    {
        Console.Write("[");
        for (int c = 0; c < m.GetLength(1); c++)
            Console.Write(c == 0 ? $"{m[f, c]}" : $", {m[f, c]}");
        Console.WriteLine("]");
    }
}
