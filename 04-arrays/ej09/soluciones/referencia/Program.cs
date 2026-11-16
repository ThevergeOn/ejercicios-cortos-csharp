int[] v = AleatoriosSinRepetir(100, 0, 999);
Console.WriteLine(string.Join(", ", v));

static int[] AleatoriosSinRepetir(int cantidad, int min, int max)
{
    Random azar = new Random();
    int[] v = new int[cantidad];
    for (int i = 0; i < v.Length; i++)
    {
        int candidato;
        do
            candidato = azar.Next(min, max + 1);
        while (Existe(v, i, candidato));        // buscar solo en las i primeras
        v[i] = candidato;
    }
    return v;
}

static bool Existe(int[] v, int hasta, int buscado)
{
    bool existe = false;
    for (int i = 0; i < hasta && !existe; i++)
        if (v[i] == buscado)
            existe = true;
    return existe;
}
