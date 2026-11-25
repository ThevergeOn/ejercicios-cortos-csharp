# Ejercicio 42

Ejercicios en los que hay que modificar un programa ya hecho que funciona correctamente y que seguramente usa constantes para que use Enums de manera más eficiente y clara. Seguramente el cambio implicará cambiar las constantes por Enums y algún switch o otras instrucciones con lo que el programa será mucho más corto y claro  

```csharp
const int LUNES = 1;
const int MARTES = 2;
const int MIERCOLES = 3;
const int JUEVES = 4;
const int VIERNES = 5;
const int SABADO = 6;
const int DOMINGO = 7;

static string NombreDia(int dia)
{
    switch (dia)
    {
        case LUNES: return "Lunes";
        case MARTES: return "Martes";
        case MIERCOLES: return "Miércoles";
        case JUEVES: return "Jueves";
        case VIERNES: return "Viernes";
        case SABADO: return "Sábado";
        case DOMINGO: return "Domingo";
        default: return "Desconocido";
    }
}

static bool EsLaborable(int dia)
{
    return dia == LUNES || dia == MARTES || dia == MIERCOLES
        || dia == JUEVES || dia == VIERNES;
}

for (int i = 1; i <= 7; i++)
{
    Console.WriteLine($"{i}. {NombreDia(i)}");
}
Console.Write("Elige un día: ");
int elegido = int.Parse(Console.ReadLine());

if (elegido < 1 || elegido > 7)
    Console.WriteLine("Día no válido");
else if (EsLaborable(elegido))
    Console.WriteLine($"{NombreDia(elegido)} es laborable");
else
    Console.WriteLine($"{NombreDia(elegido)} es fin de semana");

// Nota: en C# las constantes locales no se pueden usar dentro de métodos `static` de nivel superior en algunos contextos. Si tu proyecto lo da como error, declara las constantes dentro de la clase `Program`
```

## Soluciones

Cada persona tiene su carpeta dentro de `soluciones/`. Todavía no hay solución de referencia: ¡puedes ser la primera persona en subir la tuya!

¿Quieres añadir la tuya? Lee [CONTRIBUTING.md](../../CONTRIBUTING.md).
