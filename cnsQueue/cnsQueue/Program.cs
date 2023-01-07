

//Очередь (Queue)

//(A) Обычная очередь (устаревший)
using System.Collections;

//Queue x = new Queue();
//var x = new Queue();

Queue x = new();
x.Enqueue(6);
x.Enqueue(4);
x.Enqueue(1);
x.Enqueue("hello");
Console.WriteLine($"Смотрим -> {x.Peek()}");

while (x.Count > 0)
{
    Console.WriteLine(x.Dequeue());
}


//(Б) Обобщенная очередь
Queue<int> numbers = new();
numbers.Enqueue(1);
numbers.Enqueue(2);
numbers.Enqueue(3);
numbers.Enqueue(4);
Console.WriteLine($"Sum = {numbers.Sum()}"); //из LINQ

while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}

