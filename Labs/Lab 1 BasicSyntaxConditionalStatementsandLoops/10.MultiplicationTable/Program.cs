using System;

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} X {i} = {num*i}");
}

//int number = int.Parse(Console.ReadLine());
//int times = 1;

//while (times <= 10)
//{
//    Console.WriteLine($"{number} X {times} = {number * times}");
//    times++;
//}