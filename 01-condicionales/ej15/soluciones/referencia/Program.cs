Console.Write("Importe: ");
double importe = double.Parse(Console.ReadLine()!);
Console.Write("¿Es del club? (S/N): ");
bool esClub = Console.ReadLine()!.Trim().ToUpper() == "S";

double descuento = importe switch
{
    < 100  => 0,
    <= 300 => 0.05,
    _      => 0.10
};
if (esClub)
    descuento += 0.05;

double final = importe * (1 - descuento);
Console.WriteLine($"Descuento: {descuento * 100}%  Precio final: {final:F2} €");
