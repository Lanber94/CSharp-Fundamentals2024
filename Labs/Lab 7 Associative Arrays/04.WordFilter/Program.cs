using System.Xml.Linq;

internal class Program
{

    //static void Main(string[] args)
    //{
    //    string[] input = Console.ReadLine().Split();

    //    string[] worlds = input
    //        .Where(s => s.Length % 2 == 0)
    //        .ToArray();

    //    //Console.WriteLine(string.Join(" ", worlds));
    //    Console.WriteLine(string.Join("\n", worlds));
    //    Console.WriteLine(string.Join(Environment.NewLine, worlds));

    //}

    static void Main(string[] args)
    {


        string[] worlds = Console.ReadLine().Split()
            .Where(s => s.Length % 2 == 0)
            .ToArray();

        Console.WriteLine(string.Join(" ", worlds));
        Console.WriteLine(string.Join("\n", worlds));
        Console.WriteLine(string.Join(Environment.NewLine, worlds));

    }

    //static void Main(string[] args)
    //{


    //    Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split().Where(word => word.Length % 2 == 0)));

    //}

}
