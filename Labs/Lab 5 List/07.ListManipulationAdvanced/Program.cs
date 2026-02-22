using System.Runtime.InteropServices;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        bool hasChanges = false;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] tokens = input.Split();
            string command = tokens[0];

            switch (command)
            {

                case "Add":     //dobavi "number" v kraya
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                    break;
                case "Remove":   //premahni cisloto "number "
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove);
                    break;
                case "RemoveAt": //premahni cisloto "index"
                    int indexToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAt(indexToRemove);
                    break;
                case "Insert": //vmukni "number" "index":
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    break;



                case "Contains":
                    int numContains = int.Parse(tokens[1]);
                    numbers.Contains(numContains);  //proverka dali cisloto se namira v Lista
                    //Console.WriteLine(numbers.Contains(numContains) ? "Yes" : "No such number"); <---- ili direktno
                    if (numbers.Contains(numContains))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    hasChanges = true;
                    break;
                case "PrintEven":
                    string sum = "";
                    for (int i = 0; numbers.Count > i; i++)
                    {

                        if (numbers[i] % 2 == 0)
                        {
                            sum += numbers[i] + " ";

                        }
                    }
                    //numbers.FindAll(number => number % 2 == 0);
                    //Console.WriteLine(string.Join(" ", sum));
                    Console.WriteLine(sum);
                    hasChanges = true;
                    break;
                case "PrintOdd":
                    string sum1 = "";
                    for (int i = 0; numbers.Count > i; i++)
                    {

                        if (numbers[i] % 2 != 0)
                        {
                            sum1 += numbers[i] + " ";

                        }
                    }
                    Console.WriteLine(sum1);
                    hasChanges = true;
                    break;
                case "GetSum":
                    int total = 0;
                    for (int i = 0; numbers.Count > i; i++)
                    {
                        total += numbers[i];
                    }
                    Console.WriteLine(total);
                    hasChanges = true;
                    break;
                case "Filter":
                    ;
                    string condition = tokens[1];
                    int filterNum = int.Parse(tokens[2]);
                    string filterSum = "";
                    if (condition == ">=")
                    {

                        for (int i = 0; numbers.Count > i; i++)
                        {
                            if (numbers[i] >= filterNum)
                            {
                                filterSum += numbers[i] + " ";
                            }
                        }
                        Console.WriteLine(filterSum);

                    }
                    if (condition == "<=")
                    {
                        for (int i = 0; numbers.Count > i; i++)
                        {
                            if (numbers[i] <= filterNum)
                            {
                                filterSum += numbers[i] + " ";
                            }
                        }
                        Console.WriteLine(filterSum);

                    }
                    if (condition == "<")
                    {
                        for (int i = 0; numbers.Count > i; i++)
                        {
                            if (numbers[i] < filterNum)
                            {
                                filterSum += numbers[i] + " ";
                            }
                        }
                        Console.WriteLine(filterSum);

                    }
                    if (condition == ">")
                    {
                        for (int i = 0; numbers.Count > i; i++)
                        {
                            if (numbers[i] > filterNum)
                            {
                                filterSum += numbers[i] + " ";
                            }
                        }
                        Console.WriteLine(filterSum);
                        hasChanges = true;
                    }

                    break;
            }


        }
        if (!hasChanges)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
