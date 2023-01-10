using System.Drawing;
Random rnd = new Random();
int x = 1;

Console.Write("Введите длину стороны карты (нечётное число > 5): ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] cells = new int[width, width];

for (int j = 0; j < width; j++)
{
    Console.BackgroundColor = (ConsoleColor)8;
    Console.Write("  ");
    Console.ResetColor();
}

Console.WriteLine();

for (int i = 0; i < width - 2; i++)
{
    if (i % 2 == 1)
    {
        for (int j = 0; j < width; j++)
        {
            if (j % 2 == 0)
            {
                Console.BackgroundColor = (ConsoleColor)8;
                Console.Write("  ");
                Console.ResetColor();
            }
            else
            {
                x = rnd.Next(2);
                if (x == 1)
                {
                    Console.BackgroundColor = (ConsoleColor)2;
                }
                else
                {
                    Console.BackgroundColor = (ConsoleColor)7;
                }
                Console.Write("  ");
                Console.ResetColor();
            }
        }
    }
    else
    {
        Console.BackgroundColor = (ConsoleColor)8;
        Console.Write("  ");
        Console.ResetColor();
        for (int j = 1; j < width - 1; j++)
        {
            x = rnd.Next(2);
            if (x == 1)
            {
                Console.BackgroundColor = (ConsoleColor)2;
            }
            else
            {
                Console.BackgroundColor = (ConsoleColor)7;
            };
            Console.Write("  ");
            Console.ResetColor();
        }
        Console.BackgroundColor = (ConsoleColor)8;
        Console.Write("  ");
        Console.ResetColor();
    }
    Console.WriteLine();
}

for (int j = 0; j < width; j++)
{
    Console.BackgroundColor = (ConsoleColor)8;
    Console.Write("  ");
    Console.ResetColor();
}