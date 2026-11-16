Random azar = new Random();

Console.Write("Pulsa 'intro' para la tirada del ordenador");
Console.ReadLine();
int ordenador = azar.Next(1, 7) + azar.Next(1, 7);
Console.WriteLine($"El ordenador ha sacado {ordenador}");

Console.Write("Pulsa 'intro' para tu tirada");
Console.ReadLine();
int usuario = azar.Next(1, 7) + azar.Next(1, 7);
Console.WriteLine($"Has sacado {usuario}");

string resultado = usuario > ordenador ? "¡Ganas!"
                 : usuario < ordenador ? "Gana el ordenador"
                 : "Empate";
Console.WriteLine(resultado);
