Console.WriteLine(string.Join(", ", RepiteSegunValor([3, 1, 0, 5, 2])));   // 3, 3, 3, 1, 5, 5, 5, 5, 5, 2, 2

static int[] RepiteSegunValor(int[] v)
{
    int total = 0;
    foreach (int n in v)
        total += n;

    int[] r = new int[total];
    int pos = 0;
    foreach (int n in v)
        for (int k = 0; k < n; k++)
            r[pos++] = n;
    return r;
}
