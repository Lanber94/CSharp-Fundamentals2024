int n = int.Parse(Console.ReadLine());

// Генерираме всички възможни тройки
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            // Печатаме тройката от букви, като използваме ASCII стойностите
            Console.WriteLine($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
        }
    }
}