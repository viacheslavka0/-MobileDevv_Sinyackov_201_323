
//Слова (Dictionary)
//Ключ (уникальный) - значение


Dictionary<int, string> x = new();
x.Add(10, "Калуга");
x.Add(40, "Псков");
x.Add(75, "Самара");
x.Add(15, "Брянск");


Console.WriteLine(x[15]);
x[40] = "Воронеж";
x[99] = "Курск";


foreach (var item in x)
{
    Console.WriteLine($"Key = {item.Key}, value = {item.Value}");
}
    
    
     


    
    