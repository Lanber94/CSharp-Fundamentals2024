int n = int.Parse(Console.ReadLine());

int[] num = new int[n];

int total = 0;
for (int i = 0; i < n; i++)
{
    int passengers = int.Parse(Console.ReadLine());
    num[i] = passengers;
    total += num[i];
}

Console.WriteLine(string.Join(" ", num));
Console.WriteLine(total);