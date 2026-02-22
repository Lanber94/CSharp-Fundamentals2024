
double[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int roundedNumber = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);


    Console.WriteLine($"{numbers[i]} => {roundedNumber}");

    //bez promenliva
    //Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
}