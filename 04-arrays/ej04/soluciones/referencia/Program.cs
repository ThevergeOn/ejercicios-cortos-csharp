int[] datos = [3, 0, 3, 20, 7, 3, 0];
int[] veces = Frecuencias(datos);
for (int i = 0; i < veces.Length; i++)
    if (veces[i] > 0)
        Console.WriteLine($"{i}: {veces[i]} veces");   // 0: 2, 3: 3, 7: 1, 20: 1

static int[] Frecuencias(int[] v)
{
    int[] veces = new int[21];          // posiciones 0..20, empiezan a 0
    foreach (int n in v)
        if (n >= 0 && n <= 20)
            veces[n]++;
    return veces;
}
