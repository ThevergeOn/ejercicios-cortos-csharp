Console.Clear();
Console.CursorVisible = false;
DibujaPareja(0);
for (int vez = 1; vez <= 5; vez++)
{
    for (int d = 1; d <= 10; d++)        // se acercan
    {
        BorraPareja(d - 1);
        DibujaPareja(d);
        Thread.Sleep(60);
    }
    for (int d = 9; d >= 0; d--)         // se alejan
    {
        BorraPareja(d + 1);
        DibujaPareja(d);
        Thread.Sleep(60);
    }
}
Console.CursorVisible = true;
Console.WriteLine();

static void DibujaPareja(int d)
{
    Console.SetCursorPosition(d, 0);      Console.Write('*');
    Console.SetCursorPosition(20 - d, 0); Console.Write('*');
}

static void BorraPareja(int d)
{
    Console.SetCursorPosition(d, 0);      Console.Write(' ');
    Console.SetCursorPosition(20 - d, 0); Console.Write(' ');
}
