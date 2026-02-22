class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "exchange":
                    int index = int.Parse(commandArgs[1]);
                    numbers = ExchangeElements(numbers, index);
                    break;
                case "max":
                    string maxType = commandArgs[1];
                    PrintMaxIndex(numbers, maxType);
                    break;
                case "min":
                    string minType = commandArgs[1];
                    PrintMinIndex(numbers, minType);
                    break;
                case "first":
                    int length = int.Parse(commandArgs[1]);
                    string firstType = commandArgs[2];
                    PrintFirstElements(numbers, length, firstType);
                    break;
                case "last":
                    int lastCount = int.Parse(commandArgs[1]);
                    string lastType = commandArgs[2];
                    PrintLastElements(numbers, lastCount, lastType);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static int[] ExchangeElements(int[] array, int index)
    {
        if (CheckForOutOfRange(array, index))
        {
            Console.WriteLine("Invalid index");
            return array;
        }

        int[] changedArray = new int[array.Length];
        int changedArrayIndex = 0;

        for (int i = index + 1; i <= array.Length - 1; i++)
        {
            changedArray[changedArrayIndex++] = array[i];
        }

        for (int i = 0; i <= index; i++)
        {
            changedArray[changedArrayIndex++] = array[i];
        }

        return changedArray;
    }

    static void PrintMaxIndex(int[] numbers, string type)
    {
        int maxIndex = -1;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                if (number >= maxNumber)
                {
                    maxNumber = number;
                    maxIndex = i;
                }
            }
        }

        PrintNotDefaultIndex(maxIndex);
    }

    static void PrintMinIndex(int[] numbers, string type)
    {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                if (number <= minNumber)
                {
                    minNumber = number;
                    minIndex = i;
                }
            }
        }

        PrintNotDefaultIndex(minIndex);
    }

    static void PrintFirstElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        string firstElements = "";
        int elementCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                firstElements += $"{number}, ";
                elementCount++;
                if (elementCount >= count)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
    }

    static void PrintLastElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        string lastElements = "";
        int elementCount = 0;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                lastElements = $"{number}, " + lastElements;
                elementCount++;
                if (elementCount == count)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
    }

    static bool CheckForOutOfRange(int[] numbers, int index)
    {
        return index < 0 || index >= numbers.Length;
    }

    static bool IsOddOrEven(string type, int number)
    {
        return (type == "even" && number % 2 == 0) ||
               (type == "odd" && number % 2 != 0);
    }

    static void PrintNotDefaultIndex(int index)
    {
        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}






//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = Console.ReadLine()
//            .Split()
//            .Select(int.Parse)
//            .ToArray();

//        string command = "";
//        while ((command = Console.ReadLine()) != "end")
//        {
//            string[] commandsArguments = command.Split();
//            switch (commandsArguments[0])
//            {
//                case "excange":
//                    int index = int.Parse(commandsArguments[1]);
//                    numbers = ExcangeElements(numbers, index);
//                    break;
//                case "max":
//                    string maxType = commandsArguments[1];
//                    PrintMaxIndex(numbers, maxType);

//                    break;
//                case "min":
//                    string minType = commandsArguments[1];
//                    PrintMinIndex(numbers, minType);
//                    break;
//                case "first":
//                    int firstCount = int.Parse(commandsArguments[1]);
//                    string firstType = commandsArguments[2];
//                    PrintFirstElements(numbers, firstCount, firstType);
//                    break;
//                case "last":
//                    int lastCount = int.Parse(commandsArguments[1]);
//                    string lastType = commandsArguments[2];
//                    PrintLastElements(numbers, lastCount, lastType);
//                    break;
//            }
//        }

//        Console.WriteLine(string.Join(", ", numbers));
//    }

//    static void PrintLastElements(int[] numbers, int count, string type)
//    {
//        if (count > numbers.Length)
//        {
//            Console.WriteLine("Invalid count");
//            return;
//        }


//        string lastElements = "";
//        for (int i = numbers.Length - 1; i >= 0; i--)
//        {
//            int number = numbers[i];
//            //if (type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0)
//            //imame veche medot i kak da sazdavame bez da povtarqme! -->IsOddOrEvent method!


//            int elementCount = 0;

//            if (IsOddOrEvent(type, number))
//            {
//                lastElements = $"{number}, " + lastElements; // printirane obratno
//                elementCount++;
//                if (elementCount >= count)
//                {
//                    break;
//                }
//            }

//        }
//        Console.WriteLine($"[{lastElements.Trim(' ', ',')}]"); //Trim->premahva zapetayi
//    }

//    static void PrintFirstElements(int[] numbers, int count, string type)
//    {
//        if (count > numbers.Length)
//        {
//            Console.WriteLine("Invalid count");
//            return;
//        }


//        string firstElements = "";
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int number = numbers[i];
//            //if (type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0)
//            //imame veche medot i kak da sazdavame bez da povtarqme! -->IsOddOrEvent method!


//            int elementCount = 0;

//            if (IsOddOrEvent(type, number))
//            {
//                firstElements += $"{number}, ";
//                elementCount++;
//                if (elementCount >= count)
//                {
//                    break;
//                }
//            }

//        }
//        Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
//    }

//    static void PrintMinIndex(int[] numbers, string type)
//    {
//        int minIndex = -1;
//        int minNumber = int.MaxValue;

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int number = numbers[i];
//            if (IsOddOrEvent(type, number))
//            {
//                if (minNumber > number)
//                {
//                    minNumber = number;
//                    minIndex = i;
//                }
//            }
//        }

//        if (minIndex != 1)
//        {
//            Console.WriteLine(minIndex);
//        }
//        else
//        {
//            Console.WriteLine("No matches");
//        }
//    }

//    private static bool IsOddOrEvent(string type, int number)
//    {
//        return type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0;
//    }

//    static void PrintMaxIndex(int[] numbers, string type)
//    {
//        int maxIndex = -1;
//        int maxNumber = int.MinValue;

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int number = numbers[i];
//            if (type == "even" && number % 2 == 0 || type == "odd" && number % 2 != 0)
//            {
//                if (maxNumber < number)
//                {
//                    maxNumber = number;
//                    maxIndex = i;
//                }
//            }
//        }

//        if (maxIndex != 1)
//        {
//            Console.WriteLine(maxIndex);
//        }
//        else
//        {
//            Console.WriteLine("No matches");
//        }
//    }

//    static int[] ExcangeElements(int[] numbers, int index)
//    {
//        if (index < 0 || index > numbers.Length - 1)
//        //obratno proverka na index
//        {
//            Console.WriteLine("Invalid index");
//            return numbers;
//        }


//        int[] changedArray = new int[numbers.Length];
//        int changedArrayIndex = 0;


//        // [1, 3, 5, 7, 9]
//        for (int i = index + 1; i <= numbers.Length - 1; i++)
//        {
//            changedArray[changedArrayIndex] = numbers[i];
//            changedArrayIndex++;

//        }
//        //5, 7, 0, 0, 0]
//        for (int i = 0; i <= index; i++)
//        {
//            changedArray[changedArrayIndex] = numbers[i];
//            changedArrayIndex++;
//        }
//        //5, 7, 9, 1, 3]

//        return changedArray;
//    }

//}
