(int[] pares, int[] impares) = SeparaPosiciones([3, 1, 0, 5, 2]);
Console.WriteLine($"[{string.Join(", ", pares)}] [{string.Join(", ", impares)}]");   // [3, 0, 2] [1, 5]

static (int[] pares, int[] impares) SeparaPosiciones(int[] v)
{
    int[] pares = new int[(v.Length + 1) / 2];
    int[] impares = new int[v.Length / 2];
    for (int i = 0; i < v.Length; i++)
        if (i % 2 == 0)
            pares[i / 2] = v[i];
        else
            impares[i / 2] = v[i];
    return (pares, impares);
}
