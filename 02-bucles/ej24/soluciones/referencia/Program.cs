int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int col = 1; col <= n; col++)
    {
        bool borde = fila == 1 || fila == n || col == 1 || col == n;
        Console.Write(borde ? '#' : '*');
    }
    Console.WriteLine();
}
