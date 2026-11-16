Console.Write("Valor catastral: ");
double valor = double.Parse(Console.ReadLine()!);
Console.Write("¿Es jubilado? (S/N): ");
bool jubilado = Console.ReadLine()!.Trim().ToUpper() == "S";

double porcentaje = valor switch
{
    <= 50000 => 0.01,
    < 150000 => 0.015,
    _        => 0.02
};
double impuesto = valor * porcentaje;
if (jubilado)
    impuesto *= 0.75;
Console.WriteLine($"Impuesto: {impuesto:F2} €");
