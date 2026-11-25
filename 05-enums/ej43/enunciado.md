# Ejercicio 43

Ejercicios en los que hay que modificar un programa ya hecho que funciona correctamente y que seguramente usa constantes para que use Enums de manera más eficiente y clara. Seguramente el cambio implicará cambiar las constantes por Enums y algún switch o otras instrucciones con lo que el programa será mucho más corto y claro  

```csharp
const int ROJO = 0;
const int VERDE = 1;
const int AMBAR = 2;

static string Nombre(int estado)
{
    switch (estado)
    {
        case ROJO: return "Rojo";
        case VERDE: return "Verde";
        case AMBAR: return "Ámbar";
        default: return "?";
    }
}

static int Siguiente(int estado)
{
    switch (estado)
    {
        case ROJO: return VERDE;
        case VERDE: return AMBAR;
        case AMBAR: return ROJO;
        default: return ROJO;
    }
}

int actual = ROJO;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Paso {i + 1}: {Nombre(actual)}");
    actual = Siguiente(actual);
}
```

## Soluciones

Cada persona tiene su carpeta dentro de `soluciones/`. Todavía no hay solución de referencia: ¡puedes ser la primera persona en subir la tuya!

¿Quieres añadir la tuya? Lee [CONTRIBUTING.md](../../CONTRIBUTING.md).
