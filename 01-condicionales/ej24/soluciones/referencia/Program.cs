Random azar = new Random();
int j1 = azar.Next(1, 7), j2 = azar.Next(1, 7);
int o1 = azar.Next(1, 7), o2 = azar.Next(1, 7);
int catJ = Categoria(j1, j2), catO = Categoria(o1, o2);

string resultado;
if (catJ != catO)
    resultado = catJ > catO ? "Gana el jugador" : "Gana el ordenador";
else if (j1 + j2 != o1 + o2)
    resultado = j1 + j2 > o1 + o2 ? "Gana el jugador" : "Gana el ordenador";
else
    resultado = "Empate";
Console.WriteLine($"Jugador: {j1} {j2}  Ordenador: {o1} {o2}  → {resultado}");

// A = 3, B = 2, C = 1
static int Categoria(int d1, int d2) => d1 == d2 ? 3 : d1 + d2 >= 9 ? 2 : 1;
