Console.Write("Número (1-7): ");
int n = int.Parse(Console.ReadLine()!);
string dia = n switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miércoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sábado",
    7 => "Domingo",
    _ => "Número no válido"
};
Console.WriteLine(dia);
