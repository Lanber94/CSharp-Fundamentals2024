internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string commands = "";
        while ((commands = Console.ReadLine()) != "end")
        {
            
            if (commands == "end")
            {
                break;
            }

            string[] arguments = commands.Split();
            if (arguments[0] == "Delete")
            {
                int deleteNumber = int.Parse(arguments[1]);
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers.Remove(deleteNumber);
                }
               
            }
            //if (arguments[0] == "Insert")
            //{
            //    int elements = int.Parse(arguments[1]);
            //    int index = int.Parse(arguments[2]);
            //    numbers.Insert(index, elements);
            //}
            else
            {
                int elements = int.Parse(arguments[1]);
                int index = int.Parse(arguments[2]);
                numbers.Insert(index, elements);
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
      
    }
}

