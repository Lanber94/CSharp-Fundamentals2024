
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        //Printing a list using a for loop

        List<string> list = new List<string>() {
        "one", "two", "three", "four", "five", "six"};
        for (int index = 0; index < list.Count; index++)
        {
            Console.WriteLine("[{0}] = {1}", index, list[index]);
        }



        //Printing a list using a string.Join(…)
        List<string> list1 = new List<string>() {
        "one", "two", "three", "four", "five", "six"};
        Console.WriteLine(string.Join("; ", list1));

    }
}
