Console.WriteLine(SonIguales([1, 2, 3], [1, 2, 3]));   // True
Console.WriteLine(SonIguales([1, 2, 3], [1, 5, 3]));   // False

static bool SonIguales(int[] a, int[] b)
{
    bool iguales = true;
    for (int i = 0; i < a.Length && iguales; i++)
        if (a[i] != b[i])
            iguales = false;
    return iguales;
}
