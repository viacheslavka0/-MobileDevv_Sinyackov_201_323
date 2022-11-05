//ДЗ: Нарисовать прямоугольник с параметрами "Ширина", "Высота", "Заливка(да/нет)",
//"Символ дли рисовки", "Символ для заливки", повтор(как в примере с линией)
using System;

bool isContinue = true;
do
{
    
    Console.WriteLine("Введите длину");
    int.TryParse(Console.ReadLine(), out int x);

    Console.WriteLine("Введите ширину");
    int.TryParse(Console.ReadLine(), out int y);


    for (int i = 0; i < y; i++)
    {
     
      
            if (i % (y - 1) == 0)
            {
                Console.WriteLine(new String('*', x));
            }
            else
            {
                Console.WriteLine('*' + new String(' ', x-2) + '*');
            }
        
    }

    Console.Write("Повторить? [Y/N] ->");
    isContinue = (Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine();
} while (isContinue);
