internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List <int> commands = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int specialNum = commands[0];
        int power = commands[1];

        if (numbers.Contains(specialNum))
        {
            int index = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                index++;
                if (numbers[i] == specialNum)
                {
                    break;
                }
            }

            

            List<int> shift = numbers.GetRange(index, power);
            numbers.RemoveRange(index, power);

            List<int> right = numbers.GetRange(1, power);
            numbers.RemoveRange(1, power);

            numbers.Remove(specialNum);




            //List<int> right = numbers.GetRange(numbers.Count - power, power);
            //numbers.RemoveRange(numbers.Count - index, power);

            int sum = numbers.Sum();
            ;

            Console.WriteLine(sum);
        }
       
    }
}

