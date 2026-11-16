int[] modas = MasRepetidos([1, 3, 1, 0, 1, 5, 5, 2, 5]);
Console.WriteLine(string.Join(", ", modas));   // 1, 5

static int[] MasRepetidos(int[] v)
{
    int max = v[0];                              // 1) valor máximo
    foreach (int n in v)
        if (n > max) max = n;

    int[] veces = new int[max + 1];              // 2) cuántas veces aparece cada número
    foreach (int n in v)
        veces[n]++;

    int maxVeces = veces[0];                     // 3) mayor frecuencia
    foreach (int c in veces)
        if (c > maxVeces) maxVeces = c;

    int[] modas = [];
    for (int i = 0; i < veces.Length; i++)
        if (veces[i] == maxVeces)
            modas = [.. modas, i];
    return modas;
}
