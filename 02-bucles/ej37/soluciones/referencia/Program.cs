Console.Clear();
Console.CursorVisible = false;
DibujaTanda(0);
for (int desp = 1; desp <= 10; desp++)        // ida
{
    DibujaTanda(desp);
    Thread.Sleep(60);
    BorraTanda(desp - 1);
}
for (int desp = 9; desp >= 0; desp--)         // vuelta
{
    DibujaTanda(desp);
    Thread.Sleep(60);
    BorraTanda(desp + 1);
}
Console.CursorVisible = true;
Console.WriteLine();

static void DibujaTanda(int desp)
{
    for (int k = 0; k < 5; k++)
    {
        Console.SetCursorPosition(k * 10 + desp, 0);
        Console.Write('*');
    }
}

static void BorraTanda(int desp)
{
    for (int k = 0; k < 5; k++)
    {
        Console.SetCursorPosition(k * 10 + desp, 0);
        Console.Write(' ');
    }
}
