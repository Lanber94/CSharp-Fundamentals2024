//using System.Numerics;

using System.Numerics;

int n = int.Parse(Console.ReadLine());

long sum = 0;
int firstSnowballSnow = 0;
int firstSnowballTime = 0;
int firstSnowballQuality = 0;

for (int i = 0; i < n; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());



    long result = (long)Math.Pow(snowballSnow / snowballTime, snowballQuality);


    if (sum < result)
    {
        sum = result;
        firstSnowballSnow = snowballSnow;
        firstSnowballTime = snowballTime;
        firstSnowballQuality = snowballQuality;
    }

}
Console.WriteLine($"{firstSnowballSnow} : {firstSnowballTime} = {sum} ({firstSnowballQuality})");

