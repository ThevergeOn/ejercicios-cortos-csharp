string[] palabras = ["hola", "mundo", "C#"];
Console.WriteLine(string.Join(", ", InvierteCadenas(palabras)));   // aloh, odnum, #C

static string InvierteCadena(string t)
{
    string resultado = "";
    for (int i = t.Length - 1; i >= 0; i--)
        resultado += t[i];
    return resultado;
}

static string[] InvierteCadenas(string[] v)
{
    string[] resultado = new string[v.Length];
    for (int i = 0; i < v.Length; i++)
        resultado[i] = InvierteCadena(v[i]);
    return resultado;
}
