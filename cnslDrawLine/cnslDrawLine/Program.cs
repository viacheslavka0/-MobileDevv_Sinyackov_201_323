
bool isContinue = false;

do
{
    Console.WriteLine("Длина?");
    //(1)
    //int width;
    //int.tryparse(console.readline(), out width);


    //(2)
    int.TryParse(Console.ReadLine(), out int width);

    Console.WriteLine(new String('*', width));

    Console.WriteLine("Повторить [Y/N] ?");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
} while (isContinue);