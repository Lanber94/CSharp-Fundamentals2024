
internal class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int minNumber = GetMinNumber(firstNumber, secondNumber);
        minNumber = GetMinNumber(minNumber, thirdNumber);

        Console.WriteLine(minNumber);
    }

    private static int GetMinNumber(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}


//static void Main()
//{
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    int num3 = int.Parse(Console.ReadLine());

//    Console.WriteLine(FindSmallestNumber(num1, num2, num3));
//}

//static int FindSmallestNumber(int a, int b, int c)
//{
//    int smallest = a;

//    if (b < smallest)
//    {
//        smallest = b;
//    }

//    if (c < smallest)
//    {
//        smallest = c;
//    }

//    return smallest;
//}

