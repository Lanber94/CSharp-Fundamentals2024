using System.Data;

namespace _00_Training;

public class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>(Console.ReadLine().Split().Select(int.Parse)).ToList();

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            string[] input = command.Split();

            if (input[0] == "Delete")
            {
                int redakt = int.Parse(input[1]);
                list.RemoveAll(x=>x == redakt);

            }
            else if (input[0] == "Insert")
            {
                int elenmet = int.Parse(input[1]);
                int position = int.Parse(input[2]);

                list.Insert(position, elenmet);

            }

        }
        Console.WriteLine(string.Join(" ", list));

    }
}
