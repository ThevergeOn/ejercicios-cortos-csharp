# Cadenas

[← Volver al inicio](../README.md)

## Antes de empezar

Para simplificar los ejercicios de cadenas no tendremos en cuenta ni las vocales con acento o diéresis, ni la letra ñ,  
aunque tú, si quieres, puedes tenerlos en cuenta  
Puedes solicitar las cadenas necesarias para hacer los ejercicios al usuario con un ReadLine()  
o asignarlas directamente dentro del programa con string cadena = "Hola, mundo";  
Si en algún momento es más eficiente el uso de un stringbuilder deberás usarlo  
En todo momento puedes usar otros métodos a los ya definidos anteriormente  
No hace falta detectar errores. Las cadenas de entrada estarán siempre correctamente formadas

Puedes usar estas funciones auxiliares (están al principio de [EjerciciosCadenas.cs](EjerciciosCadenas.cs)):

```csharp
static bool EsDigito(char c) => c >= '0' && c <= '9';
static bool EsAlfabetico(char c) => Char.ToLower(c) >= 'a' && Char.ToLower(c) <= 'z' || Char.ToLower(c) == 'ñ';
static bool EsAlfaNum(char c) => EsDigito(c) || EsAlfabetico(c);
static bool EsVocal(char c) => "aeiouáéíóúü".Contains(Char.ToLower(c));
static bool EsConsonante(char c) => EsAlfabetico(c) && !EsVocal(c);
```

## Ejercicios

| Ejercicio | Enunciado | Solución de referencia |
| --- | --- | --- |
| [Ejercicio 1](ej01/enunciado.md) | Crea un método que me devuelva el número de vocales de una cadena | — |
| [Ejercicio 2](ej02/enunciado.md) | Crea un método que me devuelva el número de consonantes de una cadena | — |
| [Ejercicio 3](ej03/enunciado.md) | Crea un método que me devuelva el número de palabras de una cadena Entendemos por | — |
| [Ejercicio 4](ej04/enunciado.md) | Crea un método que me devuelva una cadena con el resultado de mezclar otras dos | — |
| [Ejercicio 5](ej05/enunciado.md) | Crea un método que me devuelva una cadena con las vocales eliminadas | — |
| [Ejercicio 6](ej06/enunciado.md) | Crea un método que me devuelva una cadena solo con las vocales de esa cadena Si | — |
| [Ejercicio 7](ej07/enunciado.md) | Crea un método que me devuelva una cadena con las consonantes primero y con las | — |
| [Ejercicio 8](ej08/enunciado.md) | Crea un método que me devuelva una cadena con la primera letra de cada palabra en | — |
| [Ejercicio 9](ej09/enunciado.md) | Crea un método al que pasaremos una cadena y una vocal y que me devolverá la misma | — |
| [Ejercicio 10](ej10/enunciado.md) | Usando el método anterior, crea un método que saque por pantalla la letra de la | — |
| [Ejercicio 11](ej11/enunciado.md) | Crea un método que me devuelva la cadena de entrada con todos sus caracteres | — |
| [Ejercicio 12](ej12/enunciado.md) | Crea un método que me devuelva la cadena de entrada con todas sus vocales duplicadas | — |
| [Ejercicio 13](ej13/enunciado.md) | Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito, | — |
| [Ejercicio 14](ej14/enunciado.md) | Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito, | — |
| [Ejercicio 15](ej15/enunciado.md) | Crea un método que me devuelva la cadena de entrada, pero si se encuentra un dígito, | — |
| [Ejercicio 16](ej16/enunciado.md) | Crea un método que partiendo de una cadena con número de caracteres par transponga | — |
| [Ejercicio 17](ej17/enunciado.md) | Crea un método que elimine todo lo que esté entre paréntesis de la cadena de entrada | — |
| [Ejercicio 18](ej18/enunciado.md) | Crea un método que elimine todo lo que esté entre paréntesis de la cadena de entrada | — |
| [Ejercicio 19](ej19/enunciado.md) | Crea un método que me devuelva la cadena de entrada convertida La cadena de entrada | — |
| [Ejercicio 20 (puede ser complejo)](ej20/enunciado.md) | Crea un método que me devuelva una cadena con las palabras de otras dos cadenas… | — |
| [Ejercicio 21](ej21/enunciado.md) | Crea un método que me devuelva una cadena con las palabras invertidas. | — |
| [Ejercicio 22](ej22/enunciado.md) | Crea un método que partiendo de una cadena con un número de palabras par, me | — |
