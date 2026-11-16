# Cómo añadir tu solución

## Reglas

1. Tu solución va en `TEMA/EJERCICIO/soluciones/TU-USUARIO-DE-GITHUB/Program.cs`.
   Ejemplo: `04-arrays/ej07/soluciones/maria-lopez/Program.cs`
2. **Un solo fichero** `Program.cs` por ejercicio, con instrucciones de nivel superior (como crea `dotnet new console` en .NET 10). Las funciones van debajo de las instrucciones.
3. Tiene que **compilar con .NET 10**. GitHub lo comprueba solo.
4. No subas las carpetas `bin/` ni `obj/`, ni ficheros `.csproj` o `.sln`.
5. Solo toca **tu carpeta**. No modifiques las soluciones de otras personas.
6. Opcional: pon un comentario al principio explicando tu idea.

```csharp
// Ejercicio 7 · Arrays · María López
// Idea: recorro los dos arrays a la vez y paro en la primera diferencia.

Console.WriteLine(SonIguales([1, 2, 3], [1, 2, 3]));

static bool SonIguales(int[] a, int[] b)
{
    // ...
}
```

## Opción A: desde la web de GitHub (sin instalar nada)

1. Entra en la carpeta del ejercicio y después en `soluciones/`.
2. Pulsa **Add file → Create new file**.
3. En el nombre escribe `tu-usuario/Program.cs`. Al escribir la `/`, GitHub crea la carpeta.
4. Pega tu código.
5. Pulsa **Commit changes…** y después **Propose changes**. GitHub crea automáticamente una copia del repositorio en tu cuenta (*fork*).
6. Pulsa **Create pull request**.
7. Espera a que termine la comprobación (✅ compila / ❌ no compila). Si falla, pulsa en *Details* para ver el error, corrígelo en tu fork y la comprobación se repite sola.

## Opción B: con git desde tu ordenador

```bash
# 1. Haz un fork desde la web (botón "Fork") y clónalo
git clone https://github.com/TU-USUARIO/ejercicios-cortos-csharp.git
cd ejercicios-cortos-csharp

# 2. Crea una rama
git checkout -b arrays-ej07

# 3. Añade tu solución y pruébala
mkdir -p 04-arrays/ej07/soluciones/TU-USUARIO
#    (crea ahí tu Program.cs)
dotnet run 04-arrays/ej07/soluciones/TU-USUARIO/Program.cs

# 4. Sube los cambios
git add 04-arrays/ej07/soluciones/TU-USUARIO/Program.cs
git commit -m "Arrays ej07: solución de TU-USUARIO"
git push origin arrays-ej07
```

Después, en GitHub, abre un **pull request** desde tu rama hacia el repositorio de clase.

## ¿Encontraste un error?

- En una solución de referencia o en un enunciado: abre un **issue** explicando el problema.
- En tu propia solución ya aceptada: envía un nuevo pull request modificando tu `Program.cs`.
