int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    char c = fila % 2 == 1 ? '*' : '#';
    for (int col = 1; col <= n; col++)
        Console.Write(c);
    Console.WriteLine();
}
