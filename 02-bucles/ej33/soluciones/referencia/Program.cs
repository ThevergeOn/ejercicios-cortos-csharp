Console.Clear();
Console.CursorVisible = false;
Dibuja(0, 0);
for (int vez = 1; vez <= 5; vez++)
{
    Ida();
    Vuelta();
}
Console.CursorVisible = true;
Console.WriteLine();

static void Ida()
{
    for (int col = 1; col <= 40; col++)
    {
        Dibuja(col, 0);
        Thread.Sleep(30);
        Borra(col - 1, 0);
    }
}

static void Vuelta()
{
    for (int col = 39; col >= 0; col--)
    {
        Dibuja(col, 0);
        Thread.Sleep(30);
        Borra(col + 1, 0);
    }
}

static void Dibuja(int col, int fila) { Console.SetCursorPosition(col, fila); Console.Write('*'); }
static void Borra(int col, int fila)  { Console.SetCursorPosition(col, fila); Console.Write(' '); }
