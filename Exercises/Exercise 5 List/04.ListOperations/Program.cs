using System.Data;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        int index;
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();
            switch (arguments[0])
            {
                case "Add":
                    list.Add(int.Parse(arguments[1]));
                    break;
                case "Insert":
                    int number = int.Parse(arguments[1]);
                     index = int.Parse(arguments[2]);
                    if (index < 0 || index > list.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }  
                    list.Insert(index, number);
                    break;

                case "Remove":
                    index = int.Parse(arguments[1]);
                    if (index < 0 || index > list.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.RemoveAt(index);
                        break;
                case "Shift":
                    string direction = arguments[1];
                    int count  = int.Parse(arguments[2]);
                    count %= list.Count;

                    if (direction == "left")
                    {
                        List<int> ShiftPart =list.GetRange(0, count);
                        list.RemoveRange(0, count);
                        list.InsertRange(list.Count, ShiftPart);
                    }
                    else if (direction == "right")
                    {
                        List<int> ShiftPart = list.GetRange(list.Count - count, count);
                        list.RemoveRange(list.Count - count, count);
                        list.InsertRange(0, ShiftPart);
                    }
                    
                    break;


            }
        }
        Console.WriteLine(string.Join(" ", list));

    }
}