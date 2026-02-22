int number = int.Parse(Console.ReadLine());
int times = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{number} X {times} = {number * times}");
    times++;
}
while (times <= 10);

//int n = int.Parse(Console.ReadLine());
//int times = int.Parse(Console.ReadLine());
//while (true)
//{
//    Console.WriteLine($"{n} X {times} = {n * times}");

//    times++;
//    if (times == 11)
//    {
//        break;
//    }
//    else if (times > 12)
//    {
//        return;
//    }

//}

