int[] num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sumOdd = 0;
int sumEven = 0;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        sumEven += num[i];
    }
    else
    {
        sumOdd += num[i];
    }
}
int result  = (sumEven-sumOdd);
Console.WriteLine($"{result}");