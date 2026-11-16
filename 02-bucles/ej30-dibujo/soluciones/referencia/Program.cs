int n = 5;

for (int fila = 1; fila <= 2 * n - 1; fila++)
{
    int k = fila <= n ? fila : 2 * n - fila;
    for (int e = 1; e <= n - k; e++) Console.Write(' ');
    Console.Write('#');
    for (int e = 1; e <= k - 1; e++) Console.Write(' ');
    Console.Write('#');
    for (int e = 1; e <= k - 1; e++) Console.Write(' ');
    Console.WriteLine('#');
}
