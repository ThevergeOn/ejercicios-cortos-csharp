Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine()!);
Console.Write("Años de carné: ");
int carne = int.Parse(Console.ReadLine()!);

int cuota = (edad, carne) switch
{
    (< 25, < 2) => 1200,
    (< 25, _)   => 1000,
    (<= 65, < 2) => 800,
    (<= 65, _)   => 600,
    (_, < 2)     => 1100,
    _            => 900
};
Console.WriteLine($"Cuota anual: {cuota} €");
