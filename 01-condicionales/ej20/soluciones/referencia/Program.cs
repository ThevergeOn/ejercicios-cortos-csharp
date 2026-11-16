Random azar = new Random();
int d1 = azar.Next(1, 7);
int d2 = azar.Next(1, 7);

string tirada = (d1, d2) switch
{
    (6, 6) => "Tirada perfecta",
    _ when d1 == d2 => "Doble",
    _ when d1 + d2 >= 10 => "Tirada fuerte",
    _ => "Tirada normal"
};
Console.WriteLine($"{d1} y {d2}: {tirada}");
