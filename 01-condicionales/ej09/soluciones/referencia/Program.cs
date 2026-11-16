Random azar = new Random();
string resultado = azar.Next(0, 2) == 0 ? "Cara" : "Cruz";
Console.WriteLine(resultado);
