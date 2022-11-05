using System.Text;



bool isContinue = true;
bool isPouring = true;


do
{
    Console.WriteLine("Введите высоту (нечётное значение):");
    int.TryParse(Console.ReadLine(), out int height);
    Console.WriteLine("Если значение чётно, оно будет округлено вверх до ближайшего нечётного!");

    height /= 2;
    String a = "*";
    int h = 1;
    int h1 = height*2 - 1;


    for (int y = height; y > 0; y--)
    {
        if (y == height)
        {
            Console.WriteLine(new String(' ', y) + a);
        }
        else
        {
            Console.WriteLine(new String(' ', y) + a + new String(' ', h) + a);
            h += 2;
        }

    }

    for (int y = 0; y <= height; y++)
    {
        if (y == height)
        {
            Console.WriteLine(new String(' ', y) + a);
        }
        else
        {
            Console.WriteLine(new String(' ', y) + a + new String(' ', h1) + a);
            h1 -= 2;
        }

    }


    Console.Write("Повторить? [Y/N] ->");
    isContinue = (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine();
}
while (isContinue);