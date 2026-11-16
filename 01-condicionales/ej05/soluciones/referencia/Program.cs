Console.Write("Carácter: ");
char c = char.ToLower(char.Parse(Console.ReadLine()!));
bool esVocal = c is 'a' or 'e' or 'i' or 'o' or 'u';
Console.WriteLine(esVocal ? "Es vocal" : "No es vocal");
