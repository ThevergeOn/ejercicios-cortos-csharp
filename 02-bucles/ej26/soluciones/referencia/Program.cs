int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int col = 0; col <= n; col++)
        Console.Write(col == 0 || col == fila || col == n ? '#' : ' ');
    Console.WriteLine();
}
