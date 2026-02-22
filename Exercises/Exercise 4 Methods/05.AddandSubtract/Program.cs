
internal class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sumResult = Sum(a, b);
        int finalResult = Subtract(sumResult, c);
        Console.WriteLine(finalResult);
    }

    static int Sum(int a, int b)
    {
        
        return a + b;
    }

    static int Subtract (int sum, int z)
    {
        return sum - z;
    }

}

