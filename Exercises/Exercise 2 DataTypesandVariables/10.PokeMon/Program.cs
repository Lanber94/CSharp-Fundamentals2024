int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor  = int.Parse(Console.ReadLine());

double sum = power * (double)0.50;


int cell = 0;


while (power >= distance)
{
    cell++;
    power -= distance;
    if (power == sum && exhaustionFactor != 0)
    {
     power /= exhaustionFactor;
    }
}


Console.WriteLine(power);
Console.WriteLine(cell);