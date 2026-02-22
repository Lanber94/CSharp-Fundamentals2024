int maxNumber = int.Parse(Console.ReadLine());

// Loop through all numbers from 1 to maxNumber
for (int currentNumber = 1; currentNumber <= maxNumber; currentNumber++)
{
    // Calculate the sum of digits of currentNumber
    int digitSum = 0;
    int tempNumber = currentNumber;

    // Sum the digits of the current number
    while (tempNumber > 0)
    {
        digitSum += tempNumber % 10;
        tempNumber = tempNumber / 10;
    }

    // Check if the sum of digits is 5, 7, or 11
    bool isSpecialNumber = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);

    // Output the result for the current number
    Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNumber);
}