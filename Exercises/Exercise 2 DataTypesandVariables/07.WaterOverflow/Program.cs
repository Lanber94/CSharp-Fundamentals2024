int n = int.Parse(Console.ReadLine());
int liters = 0;

for (int i = 0; i < n; i++)
{
    int liter = int.Parse(Console.ReadLine());
  
    liters += liter;
    if (liters > 255)
    {
        Console.WriteLine("Insufficient capacity!");
        liters-=liter;
    }
    
}
Console.WriteLine(liters);