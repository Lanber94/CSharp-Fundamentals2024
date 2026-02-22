int n = int.Parse(Console.ReadLine());

int total = 0;
for (int i = 1; i <= n; i++)
{
    char sum = char.Parse(Console.ReadLine());
    total += sum;
}
Console.WriteLine($"The sum equals: {total}");