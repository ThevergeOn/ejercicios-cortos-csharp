Console.Write("Primer número: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
    Console.WriteLine($"{a} es mayor");
else if (b > a)
    Console.WriteLine($"{b} es mayor");
else
    Console.WriteLine("Son iguales");
