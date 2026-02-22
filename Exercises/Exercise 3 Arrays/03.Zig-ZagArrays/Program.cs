int n = int.Parse(Console.ReadLine());

// Декларираме два масива с размер n
int[] firstArray = new int[n];
int[] secondArray = new int[n];

// Четем n реда с по 2 числа
for (int i = 0; i < n; i++)
{
    // Четем реда със стойностите
    string[] input = Console.ReadLine().Split();
    int firstNumber = int.Parse(input[0]);
    int secondNumber = int.Parse(input[1]);

    // Редуваме числата в масивите
    if (i % 2 == 0)
    {
        firstArray[i] = firstNumber;
        secondArray[i] = secondNumber;
    }
    else
    {
        firstArray[i] = secondNumber;
        secondArray[i] = firstNumber;
    }
}

// Отпечатваме резултатите
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));
    