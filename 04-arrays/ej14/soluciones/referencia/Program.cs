Console.WriteLine(string.Join(", ", RepiteSegun([3, 1, 0, 5, 2], [1, 2, 3, 0, 2])));   // 3, 1, 1, 0, 0, 0, 2, 2

static int[] RepiteSegun(int[] a, int[] b)
{
    int total = 0;
    foreach (int n in b)
        total += n;

    int[] r = new int[total];
    int pos = 0;
    for (int i = 0; i < a.Length; i++)
        for (int k = 0; k < b[i]; k++)
            r[pos++] = a[i];
    return r;
}
