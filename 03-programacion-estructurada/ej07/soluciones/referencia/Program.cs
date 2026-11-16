Console.Write("¿Cuántos números? ");
int cantidad = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Media: {Media(cantidad):F2}");

static double Media(int cantidad)
{
    double suma = 0;
    for (int i = 1; i <= cantidad; i++)
    {
        Console.Write($"Número {i}: ");
        suma += double.Parse(Console.ReadLine()!);
    }
    return cantidad > 0 ? suma / cantidad : 0;
}
