
int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    //vzimame poslednata cifra
    int digit = num % 10;
    //premahvame poslednata cifra
    num /= 10;
    //dobavqme poslednata cifra kim sumata
    sum += digit;
}

Console.WriteLine(sum);


//int number = int.Parse(Console.ReadLine());

//// Променлива за събиране на сумата
//int sum = 0;

//// Докато числото не стане 0
//while (number > 0)
//{
//    // Добавяме последната цифра към сумата
//    sum += number % 10;

//    // Премахваме последната цифра
//    number /= 10;
//}

//// Извеждаме резултата
//Console.WriteLine(sum);

