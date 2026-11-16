Console.Clear();
Console.CursorVisible = false;
int colAnterior = -1, filaAnterior = -1;
for (int col = 0; col <= 40; col++)
{
    int primera = col % 2 == 0 ? 0 : 1;      // fila por la que entra en esta columna
    int segunda = 1 - primera;               // la otra fila
    foreach (int fila in new int[] { primera, segunda })
    {
        Dibuja(col, fila);
        Thread.Sleep(50);
        if (colAnterior >= 0)
            Borra(colAnterior, filaAnterior);
        colAnterior = col;
        filaAnterior = fila;
    }
}
Console.CursorVisible = true;
Console.WriteLine();

static void Dibuja(int col, int fila) { Console.SetCursorPosition(col, fila); Console.Write('*'); }
static void Borra(int col, int fila)  { Console.SetCursorPosition(col, fila); Console.Write(' '); }
