int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int col = n; col >= n - fila + 1; col--)
        Console.Write(col);
    Console.WriteLine();
}
