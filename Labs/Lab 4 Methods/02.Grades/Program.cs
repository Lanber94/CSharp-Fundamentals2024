
internal class Program
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());
        PrintGradeDefinition(grade);
    }

    static void PrintGradeDefinition(double grade)
    {
        if (grade is >= 2 and <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if (grade is >= 3 && grade <= 3.49)
        {
            Console.WriteLine("Poor");
        }
        else if (grade is >= 3.5 && grade <= 4.49)
        {
            Console.WriteLine("Good");
        }
        else if (grade is >= 4.5 && grade <= 5.49)
        {
            Console.WriteLine("Very good");
        }
        else if (grade is >= 5.5 && grade <= 6)
        {
            Console.WriteLine("Excellent");
        }
    }
}

