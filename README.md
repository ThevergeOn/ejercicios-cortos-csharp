# Ejercicios cortos de C# · 1º DAM

Repositorio de la clase para **ver los enunciados de los ejercicios cortos, comparar soluciones y compartir la tuya**.

Cada ejercicio tiene su carpeta con el enunciado y una carpeta `soluciones/` donde cada persona añade la suya. Así podemos ver distintas formas de resolver el mismo problema.

## Temas


| Tema | Ejercicios | Todos los enunciados en un .cs |
| --- | --- | --- |
| [01 · Condicionales](01-condicionales/README.md) | 24 | [EjerciciosCondicionales.cs](01-condicionales/EjerciciosCondicionales.cs) |
| [02 · Bucles: dibujos y animaciones](02-bucles/README.md) | 41 | [EjerciciosBucles.cs](02-bucles/EjerciciosBucles.cs) |
| [03 · Programación estructurada](03-programacion-estructurada/README.md) | 14 | [EjerciciosProgramacionEstructurada.cs](03-programacion-estructurada/EjerciciosProgramacionEstructurada.cs) |
| [04 · Arrays](04-arrays/README.md) | 26 | [EjerciciosArrays.cs](04-arrays/EjerciciosArrays.cs) |

## Estructura

```text
01-condicionales/
├── README.md                     ← índice del tema
├── EjerciciosCondicionales.cs    ← todos los enunciados del tema, como comentarios
└── ej01/
    ├── enunciado.md              ← qué pide el ejercicio
    └── soluciones/
        ├── referencia/
        │   └── Program.cs        ← una solución posible
        └── tu-usuario-de-github/
            └── Program.cs        ← ¡la tuya!
```

## Cómo ejecutar una solución

Necesitas el **.NET SDK 10** (el del kit portable de clase sirve). Cada solución es un único `Program.cs` con instrucciones de nivel superior, así que se ejecuta directamente, sin crear proyecto:

```bash
cd 01-condicionales/ej01/soluciones/referencia
dotnet run Program.cs
```

## Cómo añadir tu solución

Lee **[CONTRIBUTING.md](CONTRIBUTING.md)**. Se puede hacer desde la web de GitHub sin instalar nada.

Cada vez que alguien propone una solución, GitHub la **compila automáticamente**. Si no compila, lo verás en la propuesta (pull request) antes de que se acepte.

## Normas

- Cada persona solo crea o modifica **su propia carpeta**.
- Las soluciones de `referencia` son una posibilidad, no "la buena". Si encuentras una forma mejor o más clara, súbela.
- Antes de mirar soluciones, intenta el ejercicio. Se aprende mucho más.
- Para dudas o errores en un enunciado, abre un *issue*.
