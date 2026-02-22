
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
    // ili direktno numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}

// ili drug nacin printirame -- 30 20 10
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[numbers.Length - i - 1] + " ");
//}



// Drug variant za resenie
//for (int i = 0; i < n; i++)
//{
//    int number = int.Parse(Console.ReadLine());
//    numbers[i] = number;
//    // ili direktno numbers[i] = int.Parse(Console.ReadLine());
//}

//Array.Reverse(numbers);

//for (int i = 0; i < n; i++)
//{
//    Console.Write(numbers[i] + " ");
//}

