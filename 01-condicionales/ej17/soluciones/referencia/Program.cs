Console.Write("Plato (1, 2, 3): ");
int plato = int.Parse(Console.ReadLine()!);
Console.Write("Bebida (A, B, C): ");
char bebida = char.ToUpper(char.Parse(Console.ReadLine()!));

int precioPlato = plato switch { 1 => 12, 2 => 15, 3 => 18, _ => 0 };
int precioBebida = bebida switch { 'A' => 2, 'B' => 3, 'C' => 4, _ => 0 };

Console.WriteLine($"Total: {precioPlato + precioBebida} €");
