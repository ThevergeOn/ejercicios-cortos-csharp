// Ejercicios cortos de Arrays
//
// Escribe tu solución debajo de cada enunciado para practicar.
// Para compartirla con la clase, súbela a ESTE_EJERCICIO/soluciones/TU-USUARIO/Program.cs
// (ver CONTRIBUTING.md en la carpeta principal del repositorio).
//
// En todo momento puedes usar otros métodos a los ya definidos anteriormente.
// No hace falta detectar errores. Crea un pequeño Main() para probar tus métodos.

// ----------------------------------------------------------------------------
// MÉTODOS ÚTILES

// ----------------------------------------------------------------------------
// Métodos útiles 1: imprimir un array
// Crea un método que imprime un array de la siguiente forma: [3, 1, 0, 5, 2]



// ----------------------------------------------------------------------------
// Métodos útiles 2: imprimir una matriz
// Crea un método que imprime una matriz de la siguiente forma:
//
// [1, 2, 3]
// [4, 5, 6]
// [7, 8, 9]



// ----------------------------------------------------------------------------
// Métodos útiles 3: imprimir una tabla dentada
// Crea un método que imprime una tabla dentada de la siguiente forma: [[1, 2, 3], [11, 12], NULL,
// [41, 42, 43, 44, 45], [51], [61, 62]]



// ----------------------------------------------------------------------------
// EJERCICIOS

// ----------------------------------------------------------------------------
// Ejercicio 1
// Crea un método que devuelve cuántos números pares tiene un array.



// ----------------------------------------------------------------------------
// Ejercicio 2
// Crea un método que nos indique cuántas veces aparece un número que le pasamos como parámetro.



// ----------------------------------------------------------------------------
// Ejercicio 3
// Crea un método que invierta las cadenas de un array de cadenas.



// ----------------------------------------------------------------------------
// Ejercicio 4
// Crea un método que nos diga cuántas veces aparecen los números del 0 al 20 en un array de
// enteros. Ayúdate de un array temporal. Se debe recorrer el array principal solo una vez.



// ----------------------------------------------------------------------------
// Ejercicio 5
// Crea un array de 100 elementos que contendrá los números del 0 al 99 desordenados y sin
// repetirse.



// ----------------------------------------------------------------------------
// Ejercicio 6
// Partiendo de un array de números enteros, crea un nuevo array con los mismos elementos; cada
// elemento del nuevo array será la suma del mismo elemento más el elemento anterior más el
// elemento siguiente del array del que partimos. Los elementos anterior al primer elemento y
// siguiente al último serán cero. Por ejemplo: Array de entrada = [3, 7, 5, 9]. Array de
// salida = [10, 15, 21, 14].



// ----------------------------------------------------------------------------
// Ejercicio 7
// Crea un método que nos indique si los elementos de dos arrays de la misma longitud son iguales.



// ----------------------------------------------------------------------------
// Ejercicio 8
// Crea un método que nos indique si los elementos de dos arrays de la misma longitud son
// parecidos. Dos números son parecidos si son el mismo número o uno es el anterior o siguiente del
// otro. Los dos arrays A y B son parecidos, B y C también son parecidos, pero A y C no lo son.
// Array A: [3, 7, 5, 9]. Array B: [4, 7, 4, 8]. Array C: [4, 8, 3, 9].



// ----------------------------------------------------------------------------
// Ejercicio 9
// Genera un array de cien números enteros con números aleatorios entre 0 y 999 sin que haya
// ninguno repetido.



// ----------------------------------------------------------------------------
// Ejercicio 10
// Dado un array de entrada con números enteros, crea un array de salida en el que cada elemento
// del array de entrada se repite tantas veces como indica su número. Ejemplo: Array de
// entrada = [3, 1, 0, 5, 2]. Array de salida = [3, 3, 3, 1, 5, 5, 5, 5, 5, 2, 2]. Nota: fíjate que como el
// cero se repite "cero" veces, en realidad, se elimina.



// ----------------------------------------------------------------------------
// Ejercicio 11
// Dado un array de entrada de números enteros positivos, calcula el número que más veces se
// repite. Deberás dar una pasada al array de entrada para obtener su valor máximo. Luego tienes
// que crear un nuevo array de 0 hasta el valor máximo donde guardarás cuántas veces se repite cada
// número. Por último debes recorrer el nuevo array para ver cuál es el número que más se repite.
// En el caso de que haya varios valores que son el máximo, darás todos esos valores. Array de
// entrada = [1, 3, 1, 0, 1, 5, 5, 2, 5]. El valor o valores que más se repiten: 1, 5



// ----------------------------------------------------------------------------
// Ejercicio 12
// Suma todos los dígitos de todos los números de un array. Array de entrada = [3, 11, 0, 52].
// Suma = 12



// ----------------------------------------------------------------------------
// Ejercicio 13
// Crea un método que dados dos arrays, que podrían tener tamaños diferentes, los mezcla en un
// nuevo array cogiendo uno, dos o tres elementos de cada array de manera alternativa. El que coja
// uno, dos o tres elementos será aleatorio. Cuando un array se acabe, se añadirán los elementos
// restantes del otro.



// ----------------------------------------------------------------------------
// Ejercicio 14
// Crea un método que dados dos arrays de la misma longitud que podríamos llamar A y B, crea un
// tercer array en el que el primer elemento de A se repite tantas veces como indica el primer
// elemento de B y así con el resto de elementos. Si un elemento del array B es cero, su
// correspondiente elemento de A no se pone. Array A = [3, 1, 0, 5, 2]. Array B = [1, 2, 3, 0, 2].
// Array salida = [3, 1, 1, 0, 0, 0, 2, 2]



// ----------------------------------------------------------------------------
// Ejercicio 15
// Crea un método que dado un array, crea dos nuevos arrays guardando los elementos que ocupan una
// posición par del primer array en uno y los que ocupan una posición impar en el otro. Array
// Entrada = [3, 1, 0, 5, 2]. Array salida A = [3, 0, 2]. Array salida B = [1, 5]



// ----------------------------------------------------------------------------
// Ejercicio 16
// Crea un método que dado un array de entrada, cree un array dentado en el que cada array sea el
// valor que indica la misma posición del array de entrada repetido tantas veces como indique ese
// valor. Si un elemento es cero, su array no existe, es decir, tiene NULL. Array Entrada = [3, 1,
// 0, 5, 2]. Array Dentado = [[3, 3, 3], [1], NULL, [5, 5, 5, 5, 5], [2, 2]]



// ----------------------------------------------------------------------------
// Ejercicio 17
// Crea un método que, dada una tabla dentada de entrada, invierte los valores de los arrays que la
// componen. Array de entrada = [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]].
// Array de salida = [[3, 2, 1], [12, 11], NULL, [45, 44, 43, 42, 41], [51], [62, 61]]



// ----------------------------------------------------------------------------
// Ejercicio 18
// Crea un método que, dada una tabla dentada de entrada, invierte los arrays que la componen.
// Array de entrada = [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]]. Array de
// salida = [[62, 61], [51], [45, 44, 43, 42, 41], NULL, [12, 11], [3, 2, 1]]



// ----------------------------------------------------------------------------
// Ejercicio 19
// Crea un método que, dada una matriz, añade una fila y una columna con la suma de los elementos
// de cada fila y columna.
//
// Matriz de entrada  Matriz de salida
// [1, 2, 3]          [ 1,  2,  3,  6]
// [4, 5, 6]          [ 4,  5,  6, 15]
// [7, 8, 9]          [ 7,  8,  9, 24]
//                    [12, 15, 18, 45]



// ----------------------------------------------------------------------------
// Ejercicio 20
// Crea un método que convierte una tabla dentada en una matriz añadiendo cero en las posiciones
// que no existen. Array de entrada = [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61,
// 62]].
//
// Matriz de salida:
// [ 1,  2,  3,  0,  0]
// [11, 12,  0,  0,  0]
// [ 0,  0,  0,  0,  0]
// [41, 42, 43, 44, 45]
// [51,  0,  0,  0,  0]
// [61, 62,  0,  0,  0]



// ----------------------------------------------------------------------------
// Ejercicio 21
// Crea un método que convierte una matriz en una tabla dentada eliminando los ceros en las
// posiciones finales de cada fila. Matriz de entrada: la de salida del ejercicio 20. Array de
// salida = [[1, 2, 3], [11, 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]]



// ----------------------------------------------------------------------------
// Ejercicio 22
// Crea un método que traspone una tabla dentada: todos los elementos que ocupan la primera
// posición en los distintos arrays de la tabla dentada formarán parte del primer array. Los que
// ocupan la segunda posición, el segundo y así sucesivamente. Array de entrada = [[1, 2, 3], [11,
// 12], NULL, [41, 42, 43, 44, 45], [51], [61, 62]]. Array de salida = [[1, 11, 41, 51, 61], [2,
// 12, 42, 62], [3, 43], [44], [45]]



// ----------------------------------------------------------------------------
// Ejercicio 23
// Crea un array con todos los números primos comprendidos entre 2 y un valor dado. Usa el
// algoritmo de la criba de Eratóstenes.
