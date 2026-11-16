int[]?[] td = [[1, 2, 3], [11, 12], null, [41, 42, 43, 44, 45], [51], [61, 62]];
ImprimeDentada(td);   // [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]]

static void ImprimeDentada(int[]?[] td)
{
    string[] filas = new string[td.Length];
    for (int i = 0; i < td.Length; i++)
        filas[i] = td[i] == null ? "NULL" : $"[{string.Join(", ", td[i]!)}]";
    Console.WriteLine($"[{string.Join(", ", filas)}]");
}
