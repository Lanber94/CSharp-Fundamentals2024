internal class Program
{
    static void Main()
    {
        
        int numberOfCommands = int.Parse(Console.ReadLine());

      
        List<string> guestList = new List<string>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string command = Console.ReadLine();
            string[] parts = command.Split();
            string name = parts[0];

            if (command.Contains("is going!"))
            {
                if (guestList.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guestList.Add(name);
                }
            }
            else if (command.Contains("is not going!"))
            {
                if (guestList.Contains(name))
                {
                    guestList.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }

        // Misafir listesini ekrana basıyoruz
        foreach (string guest in guestList)
        {
            Console.WriteLine(guest);
        }
        //Console.WriteLine(string.Join("\n", guestList)); <--2

        //for (int i = 0; i < guestList.Count; i++)   <--3
        //{
        //    Console.WriteLine(guestList[i]);
        //}
    }
}