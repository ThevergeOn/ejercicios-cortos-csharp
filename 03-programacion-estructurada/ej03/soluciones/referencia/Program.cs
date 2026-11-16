Console.Write("Número 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Número 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Número 3: ");
int c = int.Parse(Console.ReadLine()!);
Console.WriteLine(SonConsecutivos(a, b, c) ? "Son consecutivos" : "No son consecutivos");

static bool SonConsecutivos(int a, int b, int c) => b == a + 1 && c == b + 1;
