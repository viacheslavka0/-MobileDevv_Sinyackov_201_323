﻿
Console.WriteLine("Имя?");
string? name = Console.ReadLine();
Console.WriteLine("Город");
string? city = Console.ReadLine();


Console.WriteLine("Имя = " + name + ", Город = " + city);
Console.WriteLine("Имя = {0}, Город = {1}", name, city);
Console.WriteLine($"Имя = {name}, Город = {city}");

