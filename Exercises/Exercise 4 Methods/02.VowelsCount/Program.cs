
internal class Program
{
    static void Main(string[] args)
    {
       string input = Console.ReadLine();
        int number = NumberOfVowels(input);
        Console.WriteLine(number);
    }
    
    static int NumberOfVowels(string input)
    {
        int count = 0;

        input = input.ToLower();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'e' ||
                input[i] == 'o' ||
                input[i] == 'a' ||
                input[i] == 'i' ||
                input[i] == 'u')
            {
                count++;
            }
        }
        return count;
    }
}

