int n = 5;

for (int d = 1; d <= n; d++)
{
    for (int veces = 1; veces <= n - d + 1; veces++)
        Console.Write(d);
    Console.Write(' ');
}
Console.WriteLine();
