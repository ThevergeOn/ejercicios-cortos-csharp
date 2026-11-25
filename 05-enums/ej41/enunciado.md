# Ejercicio 41

Ejercicios en los que hay que modificar un programa ya hecho que funciona correctamente y que seguramente usa constantes para que use Enums de manera más eficiente y clara. Seguramente el cambio implicará cambiar las constantes por Enums y algún switch o otras instrucciones con lo que el programa será mucho más corto y claro  

```csharp
const int SUMA = 1;
const int RESTA = 2;
const int MULTIPLICACION = 3;
const int DIVISION = 4;
const int SALIR = 5;

int opcion;
do
{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion < 1 || opcion > 5)
    {
        Console.WriteLine("Opción no válida");
    }
    else if (opcion != SALIR)
    {
        Console.Write("Primer número: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        double b = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case SUMA:
                Console.WriteLine($"Resultado: {a + b}");
                break;
            case RESTA:
                Console.WriteLine($"Resultado: {a - b}");
                break;
            case MULTIPLICACION:
                Console.WriteLine($"Resultado: {a * b}");
                break;
            case DIVISION:
                if (b == 0)
                    Console.WriteLine("No se puede dividir entre 0");
                else
                    Console.WriteLine($"Resultado: {a / b}");
                break;
        }
    }
} while (opcion != SALIR);
```

## Soluciones

Cada persona tiene su carpeta dentro de `soluciones/`. Todavía no hay solución de referencia: ¡puedes ser la primera persona en subir la tuya!

¿Quieres añadir la tuya? Lee [CONTRIBUTING.md](../../CONTRIBUTING.md).
