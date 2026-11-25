// Ejercicios cortos de Cadenas
//
// Escribe tu solución debajo de cada enunciado para practicar.
// Para compartirla con la clase, súbela a ESTE_EJERCICIO/soluciones/TU-USUARIO/Program.cs
// (ver CONTRIBUTING.md en la carpeta principal del repositorio).
//
// Funciones probadas en linux
// El opèrador => se puede usar en funciones que solo tienen una línea de código y devuelven un único valor
// Tienes más información aquí: https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/lambda-operator
static bool EsDigito(char c) => c >= '0' && c <= '9';

static bool EsAlfabetico(char c) => Char.ToLower(c) >= 'a' && Char.ToLower(c) <= 'z' || Char.ToLower(c) == 'ñ';

static bool EsAlfaNum(char c) => EsDigito(c) || EsAlfabetico(c);

static bool EsVocal(char c) => "aeiouáéíóúü".Contains(Char.ToLower(c));

static bool EsConsonante(char c) => EsAlfabetico(c) && !EsVocal(c);

/*
// Descomentar para probar las funciones anteriores
ConsoleKeyInfo tecla;
Char caracter;
do
{
   tecla = Console.ReadKey(true); // true hace que la tecla pulsada no salga en pantalla
   if (tecla.Key != ConsoleKey.Escape)
   {
       caracter = tecla.KeyChar;
       Console.WriteLine(caracter.ToString() + (EsDigito(caracter)     ? " " : " no ") + "es un dígito");
       Console.WriteLine(caracter.ToString() + (EsAlfabetico(caracter) ? " " : " no ") + "es un carácter alfabético");
       Console.WriteLine(caracter.ToString() + (EsAlfaNum(caracter)    ? " " : " no ") + "es un carácter alfanumérico");
       Console.WriteLine(caracter.ToString() + (EsVocal(caracter)      ? " " : " no ") + "es una vocal");
       Console.WriteLine(caracter.ToString() + (EsConsonante(caracter) ? " " : " no ") + "es una consonante");
       Console.WriteLine();
   }
} while (tecla.Key != ConsoleKey.Escape);
*/

//Ejercicios cortos de cadenas
// Para simplificar los ejercicios de cadenas no tendremos en cuenta ni las vocales con acento o diéresis, ni la letra ñ,
// aunque tú, si quieres, puedes tenerlos en cuenta
// Puedes solicitar las cadenas necesarias para hacer los ejercicios al usuario con un ReadLine()
// o asignarlas directamente dentro del programa con string cadena = "Hola, mundo";
// Si en algún momento es más eficiente el uso de un stringbuilder deberás usarlo
// En todo momento puedes usar otros métodos a los ya definidos anteriormente
// No hace falta detectar errores. Las cadenas de entrada estarán siempre correctamente formadas

// ----------------------------------------------------------------------------
// Ejercicio 1
// Crea un método que me devuelva el número de vocales de una cadena
// Si cadena = "Hola, mundo" el programa dirá que tiene 4 vocales

// ----------------------------------------------------------------------------
// Ejercicio 2
// Crea un método que me devuelva el número de consonantes de una cadena
// Si cadena = "Hola, mundo" el programa dirá que tiene 5 consonantes

// ----------------------------------------------------------------------------
// Ejercicio 3
// Crea un método que me devuelva el número de palabras de una cadena
// Entendemos por palabra cualquier secuencia de uno o más caracteres alfanuméricos seguidos
// Si cadena = "En un@lugar.de la Mancha05, de|.#%&&cuyo    nombre no quiero acordarme" el programa dirá que tiene 12 palabras

// ----------------------------------------------------------------------------
// Ejercicio 4
// Crea un método que me devuelva una cadena con el resultado de mezclar otras dos cadenas
// El método cogerá un carácter de cada cadena de manera alternativa hasta que una de las dos se acabe
// entonces pondrá los caracteres que quedan en la cadena resultante
// Si cadenaA = "Hola, mundo"
// y  cadenaB = "azucar"
// el resultado será "Haozluac,a rmundo"

// ----------------------------------------------------------------------------
// Ejercicio 5
// Crea un método que me devuelva una cadena con las vocales eliminadas
// Si cadena = "Hola, mundo" el programa devolverá "Hl, mnd"

// ----------------------------------------------------------------------------
// Ejercicio 6
// Crea un método que me devuelva una cadena solo con las vocales de esa cadena
// Si cadena = "Hola, mundo" el programa devolverá "oauo"

// ----------------------------------------------------------------------------
// Ejercicio 7
// Crea un método que me devuelva una cadena con las consonantes primero y con las vocales después de la cadena de entrada
// Puedes usar los métodos definidos anteriormente
// Si cadena = "Hola, mundo" el programa devolverá "Hlmndoauo"

// ----------------------------------------------------------------------------
// Ejercicio 8
// Crea un método que me devuelva una cadena con la primera letra de cada palabra en mayúsculas
// Si cadena = "Hola, mundo cruel" el programa devolverá "Hola, Mundo Cruel"

// ----------------------------------------------------------------------------
// Ejercicio 9
// Crea un método al que pasaremos una cadena y una vocal
// y que me devolverá la misma cadena con todas sus vocales cambiadas por la vocal indicada
// Habrá que respetar las mayúsculas y minúsculas de la cadena original
// Puedes hacer uso de la función IsUpper(Char)
// Si cadena = "Hola, mundo" y la vocal es 'a', el programa devolverá "Hala, manda"

// ----------------------------------------------------------------------------
// Ejercicio 10
// Usando el método anterior, crea un método que saque por pantalla la letra de la canción "La mar estaba serena"
// https://www.youtube.com/watch?v=NfJHrkIXEGU
// Letra
// "La mar estaba serena, serena estaba la mar" (x2)
// "con la a:"
// "La mar astaba sarana, sarana astaba la mar" (x2)
// igual con la e, i, o y u
// "Y ahora con todas las vocales:"
// "La mar estaba serena, serena estaba la mar" (x2)

// ----------------------------------------------------------------------------
// Ejercicio 11
// Crea un método que me devuelva la cadena de entrada con todos sus caracteres duplicados
// Si cadena = "Hola, mundo" el programa devolverá "HHoollaa,,  mmuunnddoo"

// ----------------------------------------------------------------------------
// Ejercicio 12
// Crea un método que me devuelva la cadena de entrada con todas sus vocales duplicadas
// Si cadena = "Hola, mundo" el programa devolverá "Hoolaa, muundoo"

// ----------------------------------------------------------------------------
// Ejercicio 13
// Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito,
// no lo copiará y saltará (dejará de copiar) el número de caracteres que indica ese dígito
// el dígito 0 no se copia y no salta ningún carácter
// Si cadena = "Ho2xxl4holaa, m6azucarund0o" el programa devolverá "Hola, mundo"

// ----------------------------------------------------------------------------
// Ejercicio 14
// Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito,
// no lo copiará e incrementará el valor ASCII del siguiente carácter con el valor del dígito
// Por ejemplo: la secuencia "5a" dentro de una cadena se copiará como "f" porque (char)((int)'a' + 5) = 'f'
// "5x" se copiará como "c" porque cuando llega a la z, empieza por la a
// La secuencia "0d" no modifica el carácter y se copiará como "d"
// Si cadena = "H0ol5v, 2kun3ao" el programa devolverá "Hola, mundo"

// ----------------------------------------------------------------------------
// Ejercicio 15
// Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito,
// no lo copiará y repetirá el siguiente carácter, el número de veces que indique el valor del dígito
// Por ejemplo: la secuencia "5a" dentro de una cadena se copiará como "aaaaa"
// La secuencia "1d" se copiará como "d"
// La secuencia "0d" anula la escritura del siguiente carácter y se copiará como ""
// Si cadena = "1H2ol3a, 0xm4und5o" el programa devolverá "Hoolaaa, muuuundooooo"

// ----------------------------------------------------------------------------
// Ejercicio 16
// Crea un método que partiendo de una cadena con número de caracteres par transponga los caracteres dos a dos
// Si cadena = "oHal ,umdn.o" el programa devolverá "Hola, mundo."

// ----------------------------------------------------------------------------
// Ejercicio 17
// Crea un método que elimine todo lo que esté entre paréntesis de la cadena de entrada
// No se permite anidar paréntesis
// Si cadena = "Hola(Hola, mundo), mu(xxx)ndo" el programa devolverá "Hola, mundo"

// ----------------------------------------------------------------------------
// Ejercicio 18
// Crea un método que elimine todo lo que esté entre paréntesis de la cadena de entrada
// Se permite anidar paréntesis
// Si cadena = "Hola(Hola(Hola, mundo), mundo), mu(xxx)ndo" el programa devolverá "Hola, mundo"

// ----------------------------------------------------------------------------
// Ejercicio 19
// Crea un método que me devuelva la cadena de entrada convertida
// La cadena de entrada estará formada por un número par de dígitos
// cada dos dígitos y sumando 32 (valor ASCII del espacio en blanco) indicarán el valor ASCII del carácter que representan
// Por ejemplo: "16" representa (char)(16 + 32) = '0'
// "33" representa (char)(33 + 32) = 'A'
// "90" representa (char)(90 + 32) = 'z'
// "00" representa (char)(0 + 32) = ' ' (espacio en blanco)
// Si cadena = "4079766512007785786879" el programa devolverá "Hola, mundo"

// ----------------------------------------------------------------------------
// Ejercicio 20 (puede ser complejo)
// Crea un método que me devuelva una cadena con las palabras de otras dos cadenas mezcladas.
// Se elegirá una palabra de cada cadena de manera alternativa
// Cuando una cadena se acabe se podrán el resto de palabras de la cadena que queda
// todas las palabras irán separadas por un único espacio en blanco
// Si cadenaA = "En un lugar de la Mancha"
// y  cadenaB = "de cuyo nombre no quiero acordarme, no a mucho que vivia un hidalgo..."
// el resultado será "En de un cuyo lugar nombre de no la quiero Mancha acordarme no a mucho que vivia un hidalgo"

// ----------------------------------------------------------------------------
// Ejercicio 21
// Crea un método que me devuelva una cadena con las palabras invertidas.
// Si cadena = "En un lugar de la Mancha"
// el resultado será "nE nu ragul ed al ahcnaM"

// ----------------------------------------------------------------------------
// Ejercicio 22
// Crea un método que partiendo de una cadena con un número de palabras par,
// me devuelva una cadena con las palabras cambiadas de orden por parejas.
// Los signos de puntuación se ignoran.
// Las palabras estarán separados por un único espacio en blanco
// Si cadena = "En un lugar de la Mancha."
// el resultado será "un En de lugar Mancha la"


