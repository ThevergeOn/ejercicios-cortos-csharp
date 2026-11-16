Console.Write("Primer número: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Operación (+, -, *, /): ");
char op = char.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
double b = double.Parse(Console.ReadLine()!);

string salida = op switch
{
    '+' => $"{a} + {b} = {a + b}",
    '-' => $"{a} - {b} = {a - b}",
    '*' => $"{a} * {b} = {a * b}",
    '/' when b != 0 => $"{a} / {b} = {a / b}",
    '/' => "No se puede dividir entre 0",
    _ => "Operación no válida"
};
Console.WriteLine(salida);
