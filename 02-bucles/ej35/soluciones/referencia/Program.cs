Console.Clear();
Console.CursorVisible = false;
Llena();
VaciaDesdeElFinal();
Console.CursorVisible = true;
Console.WriteLine();

static void Llena()
{
    for (int col = 0; col <= 40; col++)
    {
        Dibuja(col, 0);
        Thread.Sleep(30);
    }
}

static void VaciaDesdeElFinal()
{
    for (int col = 40; col >= 0; col--)
    {
        Borra(col, 0);
        Thread.Sleep(30);
    }
}

static void Dibuja(int col, int fila) { Console.SetCursorPosition(col, fila); Console.Write('*'); }
static void Borra(int col, int fila)  { Console.SetCursorPosition(col, fila); Console.Write(' '); }
