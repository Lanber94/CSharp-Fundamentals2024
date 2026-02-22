int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    // Print the number 'i', 'i' times in each row
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();  // Move to the next line after each row
}



