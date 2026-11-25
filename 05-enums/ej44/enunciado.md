# Ejercicio 44

Ejercicios en los que hay que modificar un programa ya hecho que funciona correctamente y que seguramente usa constantes para que use Enums de manera más eficiente y clara. Seguramente el cambio implicará cambiar las constantes por Enums y algún switch o otras instrucciones con lo que el programa será mucho más corto y claro  

```csharp
const int GENERAL = 1;
const int INFANTIL = 2;
const int JUBILADO = 3;
const int ESTUDIANTE = 4;

static double Precio(int tipo)
{
    if (tipo == GENERAL) return 9.0;
    if (tipo == INFANTIL) return 5.5;
    if (tipo == JUBILADO) return 6.0;
    if (tipo == ESTUDIANTE) return 7.0;
    return 0;
}

static string Nombre(int tipo)
{
    if (tipo == GENERAL) return "General";
    if (tipo == INFANTIL) return "Infantil";
    if (tipo == JUBILADO) return "Jubilado";
    if (tipo == ESTUDIANTE) return "Estudiante";
    return "?";
}

for (int t = GENERAL; t <= ESTUDIANTE; t++)
{
    Console.WriteLine($"{t}. {Nombre(t)} - {Precio(t)} €");
}

double total = 0;
int opcion;
do
{
    Console.Write("Tipo de entrada (0 para terminar): ");
    opcion = int.Parse(Console.ReadLine());
    if (opcion >= GENERAL && opcion <= ESTUDIANTE)
    {
        Console.Write("Cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());
        total += cantidad * Precio(opcion);
    }
    else if (opcion != 0)
    {
        Console.WriteLine("Tipo no válido");
    }
} while (opcion != 0);

Console.WriteLine($"Total: {total} €");
```

## Soluciones

Cada persona tiene su carpeta dentro de `soluciones/`. Todavía no hay solución de referencia: ¡puedes ser la primera persona en subir la tuya!

¿Quieres añadir la tuya? Lee [CONTRIBUTING.md](../../CONTRIBUTING.md).
