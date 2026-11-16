int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int col = 1; col <= n; col++)
        Console.Write(col % 2 == 1 ? '*' : '#');
    Console.WriteLine();
}
