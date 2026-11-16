Console.Write("Nota: ");
double nota = double.Parse(Console.ReadLine()!);
string calificacion = nota switch
{
    < 0 or > 10 => "Nota no válida",
    < 5 => "Insuficiente",
    < 6 => "Suficiente",
    < 7 => "Bien",
    < 9 => "Notable",
    _   => "Sobresaliente"
};
Console.WriteLine(calificacion);
