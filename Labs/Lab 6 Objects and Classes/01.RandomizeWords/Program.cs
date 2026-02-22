
using System.Reflection.Metadata;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        Random random = new Random();

        for (int i = 0; i < input.Length; i++)
        {
            int randomIndex = random.Next(0, input.Length);
            SwapWords(input, i, randomIndex);   //Razmenya dumi
            //string temp = input[i];           
            //input[i] = input[randomIndex];
            //input[randomIndex] = temp;

        }

        //foreach (string inpu  in input)
        //{
        //    Console.WriteLine(inpu);
        //}

        //for (int i = 0; i < input.Length; i++)
        //{
        //    Console.WriteLine(input[i]); 
        //}

        Console.WriteLine(string.Join(Environment.NewLine, input));
    }

     static void SwapWords(string[] input, int i, int randomIndex)
    {
        string temp = input[i];
        input[i] = input[randomIndex];
        input[randomIndex] = temp;
    }
}
