int[] A = [3, 7, 5, 9], B = [4, 7, 4, 8], C = [4, 8, 3, 9];
Console.WriteLine($"{SonParecidos(A, B)} {SonParecidos(B, C)} {SonParecidos(A, C)}");   // True True False

static bool SonParecidos(int[] a, int[] b)
{
    bool parecidos = true;
    for (int i = 0; i < a.Length && parecidos; i++)
        if (Math.Abs(a[i] - b[i]) > 1)
            parecidos = false;
    return parecidos;
}
