Console.WriteLine(string.Join(", ", SumaVecinos([3, 7, 5, 9])));   // 10, 15, 21, 14

static int[] SumaVecinos(int[] v)
{
    int[] r = new int[v.Length];
    for (int i = 0; i < v.Length; i++)
    {
        int anterior = i > 0 ? v[i - 1] : 0;
        int siguiente = i < v.Length - 1 ? v[i + 1] : 0;
        r[i] = anterior + v[i] + siguiente;
    }
    return r;
}
