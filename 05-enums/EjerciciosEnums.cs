// Ejercicios cortos de Enums
//
// Escribe tu solución debajo de cada enunciado para practicar.
// Para compartirla con la clase, súbela a ESTE_EJERCICIO/soluciones/TU-USUARIO/Program.cs
// (ver CONTRIBUTING.md en la carpeta principal del repositorio).
//
// Los ejercicios 41 a 44 incluyen el programa original que hay que modificar.
/* EJERCICIOS DE TIPO 1
Ejercicios de Enums pensados para que en nuestros programas haya solo un punto de cambio. Es decir, que si se quiere ampliar un menú o unas opciones, solo haya que añadir un elemento al Enum y no haya que tocar nada más (o casi nada más) en el programa para que funcione */

// ----------------------------------------------------------------------------
// Ejercicio 11
// Menú principal de una agenda: Enum `OpcionAgenda` (Añadir, Buscar, Listar, Borrar, Salir). El menú se genera automáticamente a partir del enum, numerando las opciones según su valor, y el bucle termina al elegir `Salir`.

// ----------------------------------------------------------------------------
// EJERCICIO 12
// Cafetería: Enum `Bebida` (Café, Té, Cola, Agua…). Se muestra la carta recorriendo el enum, el usuario elige varias bebidas y el programa calcula el total. El precio se obtiene con un único `switch` o método.

// ----------------------------------------------------------------------------
// EJERCICIO 13
// Piedra, papel o tijera: Enum `Jugada`. El ordenador elige una jugada aleatoria con `Random.Next(0, número de elementos del enum)`. Añadir una jugada nueva (por ejemplo Lagarto) no debe obligar a cambiar el sorteo ni el menú.

// ----------------------------------------------------------------------------
// EJERCICIO 14
// Cajero automático: Enum `OpcionCajero` (Consultar, Ingresar, Retirar, Salir). Menú generado desde el enum, con saldo inicial y bucle hasta elegir `Salir`. Añadir una opción nueva solo implica una nueva línea en el enum y su caso.

/* EJERCICIOS DE TIPO 2
Ejercicios de Enums con Arrays */

// ----------------------------------------------------------------------------
// EJERCICIO 21
// Notas por asignatura: Enum `Asignatura` (Matemáticas, Lengua, Inglés, Historia…). Un array de `double` con tantas posiciones como elementos tiene el enum, indexado con el enum. El programa pide la nota de cada asignatura (mostrando su nombre) y calcula la media.

// ----------------------------------------------------------------------------
// EJERCICIO 22
// Contador de votos: Enum `Partido` (4–5 partidos). El usuario vota repetidamente hasta introducir la opción de terminar. Al final se muestra el número de votos y el porcentaje de cada partido, y el ganador.

// ----------------------------------------------------------------------------
// EJERCICIO 23
// Frecuencia de dados: de un enum cualquier (por ejemplo los palos de la baraja española) se genera un array con cien elementos aleatorios de ese enum. Se recorre el array y se calcula la frecuencia de cada elemento del enum, el elemento que más sale y el que menos sale, mostrando el array con los elementos que han salido y el resultado al final.

// ----------------------------------------------------------------------------
// EJERCICIO 24
// Estadística de respuestas de encuesta: Enum `Valoracion` (MuyMala, Mala, Regular, Buena, MuyBuena). El usuario introduce valoraciones hasta escribir un valor de fin. Se muestran los conteos y la valoración más repetida (moda).

// ----------------------------------------------------------------------------
// EJERCICIO 25
// Velocidad de animales: Enum `Animal` y array de velocidades máximas. El usuario introduce una distancia y el programa muestra cuánto tardaría cada animal, en una tabla ordenada por la posición del enum.

// ----------------------------------------------------------------------------
// EJERCICIO 26
// Reparto de tareas: partiendo de un Enum `Persona` (Ana, Luis, Marta, Pedro…) y array con una serie de veinte tareas. El programa asigna 20 tareas de forma aleatoria a una persona y luego muestra el recuento por persona, indicando quién tiene más y quién menos.

/* EJERCICIOS DE TIPO 3
Otros ejercicios*/

// ----------------------------------------------------------------------------
// EJERCICIO 31
// Semáforo: Enum `EstadoSemaforo` (Rojo, Verde, Ámbar). Un método `Siguiente(estado)` devuelve el estado siguiente del ciclo. Simula 10 cambios mostrando cada estado.

// ----------------------------------------------------------------------------
// EJERCICIO 32
// Puerta con llave: Enum `EstadoPuerta` (Abierta, Cerrada, Bloqueada). El usuario introduce acciones (abrir, cerrar, bloquear, desbloquear). El programa solo permite las transiciones válidas y avisa en las demás (por ejemplo, no se puede abrir una puerta bloqueada). Guarda las trasiciones permitidas en una tabla dentada

// ----------------------------------------------------------------------------
// EJERCICIO 33
// Crea un método al que pasamos un array y un valor del array. El método devuelve un enum indicando si el valor no está en el array, si está una vez o si está varias veces. Enum `ResultadoBusqueda` (NoEncontrado, UnaVez, VariasVeces). Crea un pequeño main para probarlo con un array de enteros generado aleatoriamente y un valor introducido por el usuario. Muestra el array y el resultado de la búsqueda.

/* EJERCICIOS DE TIPO 4
Ejercicios en los que hay que modificar un programa ya hecho que funciona correctamente y que seguramente usa constantes para que use Enums de manera más eficiente y clara. Seguramente el cambio implicará cambiar las constantes por Enums y algún switch o otras instrucciones con lo que el programa será mucho más corto y claro */

// ----------------------------------------------------------------------------
// EJERCICIO 41

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

// ----------------------------------------------------------------------------
// EJERCICIO 42
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

// ----------------------------------------------------------------------------
// EJERCICIO 43
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

// ----------------------------------------------------------------------------
// EJERCICIO 44
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

