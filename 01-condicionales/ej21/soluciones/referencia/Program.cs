Random azar = new Random();
int a = azar.Next(1, 5), b = azar.Next(1, 5), c = azar.Next(1, 5);

string premio;
if (a == b && b == c)
    premio = "Premio grande";
else if (a == b || a == c || b == c)
    premio = "Premio pequeño";
else
    premio = "Sin premio";

Console.WriteLine($"{Simbolo(a)} | {Simbolo(b)} | {Simbolo(c)} → {premio}");

static string Simbolo(int n) => n switch
{
    1 => "Campana",
    2 => "Limón",
    3 => "Cereza",
    _ => "Siete"
};
