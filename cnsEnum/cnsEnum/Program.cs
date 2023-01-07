class Program
{
    //public enum SingleColor { Red, Green = 100500, Blue}
    public enum SingleColor : byte { Red, Green = 55, Blue}

    static void Main()
    {
        SingleColor singleColor;
        singleColor = SingleColor.Green;


        Console.WriteLine(singleColor);
        Console.WriteLine(singleColor.ToString("D"));
        Console.WriteLine(Enum.GetUnderlyingType(singleColor.GetType()));
    }
}