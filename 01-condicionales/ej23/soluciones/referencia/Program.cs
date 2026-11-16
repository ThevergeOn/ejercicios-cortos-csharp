Random azar = new Random();
int j1 = azar.Next(1, 7), j2 = azar.Next(1, 7);
int o1 = azar.Next(1, 7), o2 = azar.Next(1, 7);
bool parejaJ = j1 == j2, parejaO = o1 == o2;
int sumaJ = j1 + j2, sumaO = o1 + o2;

string resultado = (parejaJ, parejaO) switch
{
    (true, false) => "Gana el jugador (pareja)",
    (false, true) => "Gana el ordenador (pareja)",
    _ when sumaJ > sumaO => "Gana el jugador",
    _ when sumaO > sumaJ => "Gana el ordenador",
    _ => "Empate"
};
Console.WriteLine($"Jugador: {j1} {j2}  Ordenador: {o1} {o2}  → {resultado}");
