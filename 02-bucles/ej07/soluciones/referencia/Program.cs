int n = 5;

for (int fila = 1; fila <= n; fila++)
{
    int digito = n - fila + 1;
    for (int veces = 1; veces <= n; veces++)
        Console.Write(digito);
    Console.WriteLine();
}
