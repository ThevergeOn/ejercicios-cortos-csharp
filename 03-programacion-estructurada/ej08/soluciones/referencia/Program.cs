int contador = 0;
int insuf = 0, suf = 0, bien = 0, notable = 0, sobre = 0;
double suma = 0, maxima = 0, minima = 0;

double nota = LeeNota();
while (nota >= 0)
{
    if (contador == 0)
        maxima = minima = nota;
    if (nota > maxima) maxima = nota;
    if (nota < minima) minima = nota;
    suma += nota;
    contador++;
    switch (Calificacion(nota))
    {
        case "Insuficiente": insuf++;   break;
        case "Suficiente":   suf++;     break;
        case "Bien":         bien++;    break;
        case "Notable":      notable++; break;
        default:             sobre++;   break;
    }
    nota = LeeNota();
}

if (contador > 0)
    Console.WriteLine($"Máxima: {maxima}  Mínima: {minima}  Media: {suma / contador:F2}");
Console.WriteLine($"Insuf: {insuf}  Suf: {suf}  Bien: {bien}  Not: {notable}  Sobr: {sobre}");

static double LeeNota()
{
    Console.Write("Nota (negativa para terminar): ");
    return double.Parse(Console.ReadLine()!);
}

static string Calificacion(double nota) => nota switch
{
    < 5 => "Insuficiente",
    < 6 => "Suficiente",
    < 7 => "Bien",
    < 9 => "Notable",
    _   => "Sobresaliente"
};
