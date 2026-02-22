
internal class Program
{
    static void Main(string[] args)
    {
        //string[] words = Console.ReadLine().Split();
        //List<string> result = Console.ReadLine().Split().ToList();

        //2 8 23 39 19 7

        List<int> numbers =Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToList();
    }
}

