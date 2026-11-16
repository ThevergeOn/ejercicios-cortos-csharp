Console.Write("¿Convertir de C a F (1) o de F a C (2)? ");
int opcion = int.Parse(Console.ReadLine()!);
Console.Write("Temperatura: ");
double t = double.Parse(Console.ReadLine()!);

if (opcion == 1)
    Console.WriteLine($"{t} °C = {CelsiusAFahrenheit(t):F1} °F");
else
    Console.WriteLine($"{t} °F = {FahrenheitACelsius(t):F1} °C");

static double CelsiusAFahrenheit(double c) => 9.0 / 5 * c + 32;
static double FahrenheitACelsius(double f) => (f - 32) * 5 / 9.0;
