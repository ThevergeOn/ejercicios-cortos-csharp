Console.Clear();
Console.CursorVisible = false;
Dibuja(0, 0);
for (int col = 1; col <= 40; col++)
{
    Dibuja(col, 0);
    Thread.Sleep(50);
    Borra(col - 1, 0);
}
Console.CursorVisible = true;
Console.WriteLine();

static void Dibuja(int col, int fila) { Console.SetCursorPosition(col, fila); Console.Write('*'); }
static void Borra(int col, int fila)  { Console.SetCursorPosition(col, fila); Console.Write(' '); }
