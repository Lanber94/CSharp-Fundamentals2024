int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

// 10 5 5 --- 99 --- 3 4 2 5 1 1 4
int index = -1;


for (int i = 0; i < numbers.Length; i++)             
{

    int leftSum = 0;
    int rightSum = 0;

    for (int j = i-1; j >= 0; j--)
    {
        leftSum += numbers[j];
    }
    for (int j = i+1; j < numbers.Length; j++)
    {
        rightSum += numbers[j];
    }

    if (leftSum == rightSum)
    {
        index = i;        
        break;
    }
}

if (index != -1)                      
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("no");
}




