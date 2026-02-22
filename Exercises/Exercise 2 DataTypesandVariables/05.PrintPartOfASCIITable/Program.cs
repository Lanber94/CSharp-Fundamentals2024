//int start = int.Parse(Console.ReadLine());
//int end = int.Parse(Console.ReadLine());

//int i = start;
//for (; i < end; i++)
//{
//    Console.Write($"{(char)i} ");
//}

//Console.WriteLine((char)i);



int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

// Looping through the range from start to end
for (int i = start; i <= end; i++)
{
    // Printing the corresponding character for the current ASCII index
    Console.Write((char)i + " ");
}
// Move to the next line after printing all characters
Console.WriteLine();
    