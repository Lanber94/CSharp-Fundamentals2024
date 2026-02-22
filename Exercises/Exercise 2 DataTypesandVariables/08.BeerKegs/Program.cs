int n = int.Parse(Console.ReadLine());

string biggestKegModel = "";
double biggestKeg = 0;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    
    double volume = Math.PI * (radius * radius) * height;
    
    if (biggestKeg < volume)
    {
        biggestKeg = volume;
        biggestKegModel = model;
    }
}
Console.WriteLine(biggestKegModel);