class Write
{
    public static void Title(string text)
    {
        Console.WriteLine(text);
    }

    public static void Paragraph(string text)
    {
        Console.WriteLine($"    {text}");
    }

    public static void Enlisted(int listIndex, string text)
    {
        Console.WriteLine($"      {listIndex}- {text}");
    }

    public static void Enlisted(char listChar, string text)
    {
        Console.WriteLine($"      {listChar}- {text}");
    }

    public static void LineJump()
    {
        Console.Write("\n");
    }

    public static void Lines()
    {
        Console.WriteLine("------------------------------");
    }
}