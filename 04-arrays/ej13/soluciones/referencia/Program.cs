int[] r = Mezcla([1, 2, 3, 4, 5, 6, 7], [10, 20, 30]);
Console.WriteLine(string.Join(", ", r));   // p. ej.: 1, 2, 10, 3, 20, 30, 4, 5, 6, 7

static int[] Mezcla(int[] a, int[] b)
{
    Random azar = new Random();
    int[] r = [];
    int ia = 0, ib = 0;
    bool turnoA = true;
    while (ia < a.Length && ib < b.Length)
    {
        int k = azar.Next(1, 4);                      // 1, 2 o 3
        if (turnoA)
        {
            k = Math.Min(k, a.Length - ia);
            r = [.. r, .. a[ia..(ia + k)]];
            ia += k;
        }
        else
        {
            k = Math.Min(k, b.Length - ib);
            r = [.. r, .. b[ib..(ib + k)]];
            ib += k;
        }
        turnoA = !turnoA;
    }
    return [.. r, .. a[ia..], .. b[ib..]];           // lo que quede de cada uno
}
