int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    for (int i = 1; i <= fila - 1; i++) Console.Write('*');
    for (int i = 1; i <= n; i++)        Console.Write('#');
    for (int i = 1; i <= n - fila; i++) Console.Write('*');
    Console.WriteLine();
}
