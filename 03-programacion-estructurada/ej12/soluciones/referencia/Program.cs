int secreto = new Random().Next(1, 101);
int intentos = 0;
int numero;
do
{
    Console.Write("Adivina (1-100): ");
    numero = int.Parse(Console.ReadLine()!);
    intentos++;
    if (numero < secreto)
        Console.WriteLine("El número secreto es mayor.");
    else if (numero > secreto)
        Console.WriteLine("El número secreto es menor.");
} while (numero != secreto);
Console.WriteLine($"¡Acertaste en {intentos} intentos!");
