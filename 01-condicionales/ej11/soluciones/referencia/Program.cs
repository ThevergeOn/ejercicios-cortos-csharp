Random azar = new Random();
int dado1 = azar.Next(1, 7);
int dado2 = azar.Next(1, 7);
int total = dado1 + dado2;
if (dado1 == dado2)
    total += 2;
Console.WriteLine($"Dado 1: {dado1}  Dado 2: {dado2}  Total: {total}");
