int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int e = 1; e <= fila - 1; e++) Console.Write(' ');
    for (int i = 1; i <= n; i++)        Console.Write('#');
    Console.WriteLine();
}
