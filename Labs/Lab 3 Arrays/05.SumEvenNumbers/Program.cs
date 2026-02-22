int[] num = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
        sum += num[i];
    }
}

Console.WriteLine(sum);