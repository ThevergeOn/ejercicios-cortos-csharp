Random azar = new Random();
string colorOrdenador = azar.Next(1, 5) switch
{
    1 => "ROJO",
    2 => "VERDE",
    3 => "AZUL",
    _ => "AMARILLO"
};

Console.Write("Adivina el color (rojo, verde, azul, amarillo): ");
string colorUsuario = Console.ReadLine()!.Trim().ToUpper();

Console.WriteLine(colorUsuario == colorOrdenador
    ? "¡Has acertado!"
    : $"Fallaste. Era {colorOrdenador}");
