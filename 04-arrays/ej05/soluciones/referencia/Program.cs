int[] v = Desordenados(100);
Console.WriteLine(string.Join(", ", v));

static int[] Desordenados(int cantidad)
{
    int[] v = new int[cantidad];
    for (int i = 0; i < v.Length; i++)
        v[i] = i;                               // 0, 1, 2, ..., 99

    Random azar = new Random();
    for (int i = 0; i < v.Length; i++)
    {
        int j = azar.Next(0, v.Length);         // posición aleatoria
        int aux = v[i];                         // intercambio
        v[i] = v[j];
        v[j] = aux;
    }
    return v;
}
