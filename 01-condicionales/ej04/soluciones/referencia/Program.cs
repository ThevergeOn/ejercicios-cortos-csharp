Console.Write("Importe de la compra: ");
double importe = double.Parse(Console.ReadLine()!);
if (importe > 100)
    importe *= 0.9;
Console.WriteLine($"Total a pagar: {importe:F2} €");
