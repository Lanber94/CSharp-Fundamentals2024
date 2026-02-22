int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    int sum = 0;
    int currentNumber = i;

    while (currentNumber > 0)
    {
        //124 - special number with sum 1 + 2 + 4 = 7;
        //124 % 10 = 4 ->
        //124 / 10 = 12

        //12 % 10 = 2 ->
        //12 / 10 = 1

        //1 % 10 = 1 ->
        // 1 / 10 = 0

        sum += currentNumber % 10;
        currentNumber = currentNumber / 10;

    }
    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}