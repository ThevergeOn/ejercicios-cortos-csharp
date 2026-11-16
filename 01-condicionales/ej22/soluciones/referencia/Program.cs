Random azar = new Random();
int ataque = azar.Next(20, 101);
int defensa = azar.Next(10, 61);
int danyo = Math.Max(0, ataque - defensa);

string tipo = danyo switch
{
    0     => "Sin daño",
    <= 20 => "Daño leve",
    <= 50 => "Daño medio",
    _     => "Daño crítico"
};
Console.WriteLine($"Ataque {ataque} - Defensa {defensa} = {danyo}: {tipo}");
