

internal class Program
{
    static void Main(string[] args)
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());

        if (second <  first)
        {
            char swap = first;
            first = second;
            second = swap;
        }
        PrintBetween(first, second);
    }

    private static void PrintBetween(char firstChar, char secondChar)
    {
        for (int i = firstChar +1;  i < secondChar; i++)
        {
            Console.Write($"{(char)i} ");
        }
    }
}

