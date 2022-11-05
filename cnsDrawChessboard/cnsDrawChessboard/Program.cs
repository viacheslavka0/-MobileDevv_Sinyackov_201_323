var leters = "    a b c d e f g h    ";

Console.WriteLine(leters);
//Console.BackgroundColor = ConsoleColor.White; 15
//Console.BackgroundColor = ConsoleColor.Black; 0

int g = 2;

for (int x = 1; x <= 8; x++)
{
    Console.Write($" {x} ");

    for (int y = 0; y < 8; y++)
    {
        if (g % 2 == 0)
            Console.BackgroundColor = ConsoleColor.Black;
        else
            Console.BackgroundColor = ConsoleColor.White;

        g++;

        Console.Write("  ");
        Console.ResetColor();
    }
    Console.Write($" {x} ");

    g++;

    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine(leters);