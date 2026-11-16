int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    Console.Write('#');
    for (int e = 1; e <= fila - 1; e++) Console.Write(' ');
    Console.WriteLine('#');
}
