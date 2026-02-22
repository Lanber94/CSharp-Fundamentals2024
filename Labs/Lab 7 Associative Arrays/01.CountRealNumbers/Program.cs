

internal class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<double, int> numbersCpunt = new();

        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (double number in numbers)
        {
            if(!numbersCpunt.ContainsKey(number))
            {
                numbersCpunt.Add(number, 0);
                //numbersCpunt[number] = 0;
            }

            numbersCpunt[number]++;

        }

        foreach (KeyValuePair<double, int> item in numbersCpunt) 
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        //foreach ((double asd, int fdg) in numbersCpunt)
        //{
        //    Console.WriteLine($"{asd} -> {fdg}");
        //}
    }
}

