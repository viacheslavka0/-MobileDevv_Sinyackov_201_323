//Список (list)

// (A) Обычный список (устаревший)

using System.Collections;

ArrayList arrayList = new();
arrayList.Add(123);
arrayList.Add("Привет");
arrayList.Add(3.14);
//...


// (Б) Обобщенный список
List<string> cities = new() { "Москва", "Воронеж", "Севастополь" };
cities.Add("Астана");
cities.AddRange(new string[] { "Тула", "Ялта" });
cities.RemoveAt(1);
cities.Reverse();
Console.WriteLine(String.Join(' ', cities));
cities.Sort();
Console.WriteLine(String.Join(' ', cities));