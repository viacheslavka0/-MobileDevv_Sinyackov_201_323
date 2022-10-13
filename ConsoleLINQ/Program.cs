

var arr0 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var arr = Enumerable.Range(0, 10).ToArray();

var myQuery = 
    from v in arr
    where v>5 && v<8
    orderby v descending
    select v;

Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(String.Join(" ", myQuery));
Console.WriteLine($"Count = {myQuery.Count()}, Sum = {myQuery.Sum()} ");

//2 пример

var cities0 = new string[] { "Москва", "Тула", "Воронеж", "Смоленск", "Полтава" };
var cities1 =  "Москва, Тула, Воронеж, Смоленск, Полтава".Split(", ") ;

Console.WriteLine(String.Join(" ", cities0));
Console.WriteLine(String.Join(" ", cities1));

var MyQuery2 =
    from v in cities1
    where v.ToLower().EndsWith("а")
    select $"<{v.ToUpper()}>" ;

Console.WriteLine(String.Join(" ", MyQuery2));




