Console.Clear();
Console.CursorVisible = false;
for (int col = 0; col <= 40; col++)
{
    Dibuja(col, 0);
    Thread.Sleep(30);
}
for (int col = 0; col <= 40; col++)
{
    Borra(col, 0);
    Thread.Sleep(30);
}
Console.CursorVisible = true;
Console.WriteLine();

static void Dibuja(int col, int fila) { Console.SetCursorPosition(col, fila); Console.Write('*'); }
static void Borra(int col, int fila)  { Console.SetCursorPosition(col, fila); Console.Write(' '); }
