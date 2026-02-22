
internal class Program
{
    static void Main()
    {
       double width = double.Parse(Console.ReadLine());
       double height = double.Parse(Console.ReadLine());

       double rectangleArea = CalculateRectangleArea(width, height);
        Console.WriteLine(rectangleArea);

    }

    static double CalculateRectangleArea(double width, double height)
    {
        return (width * height);
    }

}


