
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = Matrix(n);

    }

    static int Matrix(int n)
    {

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine(n + " ");
        }
        return n;
    }
}




//static void Main()
//{
//    int n = int.Parse(Console.ReadLine());

//    PrintMatrix(n);
//}

//static void PrintMatrix(int n)
//{
//    for (int i = 0; i < n; i++)
//    {
//        for (int j = 0; j < n; j++)
//        {
//            Console.Write($"{n} ");
//        }
//        Console.WriteLine();
//    }
//}
