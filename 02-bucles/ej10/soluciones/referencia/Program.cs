int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    if (fila == 1)
        for (int col = 1; col <= n; col++) Console.Write(col);
    else if (fila == n)
        for (int col = 1; col <= n; col++) Console.Write(n);
    else
        Console.Write(fila);
    Console.WriteLine();
}
