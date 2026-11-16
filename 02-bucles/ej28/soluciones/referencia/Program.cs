int n = 5;

for (int fila = 0; fila <= n + 1; fila++)
{
    for (int col = 0; col <= n + 1; col++)
    {
        bool marco = fila == 0 || fila == n + 1 || col == 0 || col == n + 1;
        Console.Write(marco || col == fila ? '#' : ' ');
    }
    Console.WriteLine();
}
