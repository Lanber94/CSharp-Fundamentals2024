using System;
using System.ComponentModel.Design;
using System.Diagnostics;

//double count = double.Parse(Console.ReadLine());
//string typeOfGroup = Console.ReadLine();
//string dayOfWeek = Console.ReadLine();
//double price = 0;



//switch (typeOfGroup)
//{
//    case "Students":
//        if (dayOfWeek == "Friday")
//        {
//            price = count * 8.45;
//            if (count >= 30)
//            {
//                price *= 0.85;
//            }

//        }
//        else if (dayOfWeek == "Saturday")
//        {
//            price = count * 9.80;
//            if (count >= 30)
//            {
//                price *= 0.85;
//            }
//        }
//        else if (dayOfWeek == "Sunday")
//        {
//            price = count * 10.46;
//            if (count >= 30)
//            {
//                price *= 0.85;
//            }
//        }
//        break;
//    case "Business":
//        if (dayOfWeek == "Friday")
//        {
//            price = count * 10.90;
//            if (count >= 100)
//            {
//                price -= 10 * (price / count); 
//            }
//        }
//        else if (dayOfWeek == "Saturday")
//        {
//            price = count * 15.60;
//            if (count >= 100)
//            {
//                price -= 10 * (price / count);
//            }
//        }
//        else if (dayOfWeek == "Sunday")
//        {
//            price = count * 16;
//            if (count >= 100) 
//            {
//                price -= 10 * (price / count); 
//            }
//        }
//        break;
//    case "Regular":
//        if (dayOfWeek == "Friday")
//        {
//            price = count * 15;
//            if (count >= 10 && count <= 20)
//            {
//                price *= 0.95;
//            }
//        }
//        else if (dayOfWeek == "Saturday")
//        {
//            price = count * 20;
//            if (count >= 10 && count <= 20)
//            {
//                price *= 0.95;
//            }
//        }
//        else if (dayOfWeek == "Sunday")
//        {
//            price = count * 22.50;
//            if (count >= 10 && count <= 20)
//            {
//                price *= 0.95;
//            }
//        }
//        break;
//}
//Console.WriteLine($"Total price: {price:f2}");



//---------------------------------------------------------------------------------------


double count = double.Parse(Console.ReadLine());
// Тип на групата
string typeOfGroup = Console.ReadLine();
// Ден от седмицата
string dayOfWeek = Console.ReadLine();
double price = 0;

switch (typeOfGroup)
{
    case "Students":
        if (dayOfWeek == "Friday")
        {
            price = count * 8.45;
        }
        else if (dayOfWeek == "Saturday")
        {
            price = count * 9.80;
        }
        else if (dayOfWeek == "Sunday")
        {
            price = count * 10.46;
        }

        if (count >= 30)
        {
            price *= 0.85;  // Отстъпка за 30 или повече студенти
        }
        break;

    case "Business":
        if (dayOfWeek == "Friday")
        {
            price = count * 10.90;
        }
        else if (dayOfWeek == "Saturday")
        {
            price = count * 15.60;
        }
        else if (dayOfWeek == "Sunday")
        {
            price = count * 16;
        }

        if (count >= 100)
        {
            price -= 10 * (price / count);  // 10 човека остават безплатно
        }
        break;

    case "Regular":
        if (dayOfWeek == "Friday")
        {
            price = count * 15;
        }
        else if (dayOfWeek == "Saturday")
        {
            price = count * 20;
        }
        else if (dayOfWeek == "Sunday")
        {
            price = count * 22.50;
        }

        if (count >= 10 && count <= 20)
        {
            price *= 0.95;  // Отстъпка за групи между 10 и 20
        }
        break;
}

// Извеждаме крайната цена
Console.WriteLine($"Total price: {price:f2}");



//---------------------------------------------------------------------------------------


//int count = int.Parse(Console.ReadLine());  // Number of people
//string typeOfGroup = Console.ReadLine();    // Type of the group (Students, Business, Regular)
//string dayOfWeek = Console.ReadLine();      // Day of the week (Friday, Saturday, Sunday)

//double pricePerPerson = 0;

//// Set price per person based on the group type and day
//if (typeOfGroup == "Students")
//{
//    if (dayOfWeek == "Friday") pricePerPerson = 8.45;
//    else if (dayOfWeek == "Saturday") pricePerPerson = 9.80;
//    else if (dayOfWeek == "Sunday") pricePerPerson = 10.46;

//    // Apply 15% discount if there are 30 or more students
//    if (count >= 30) pricePerPerson *= 0.85;
//}
//else if (typeOfGroup == "Business")
//{
//    if (dayOfWeek == "Friday") pricePerPerson = 10.90;
//    else if (dayOfWeek == "Saturday") pricePerPerson = 15.60;
//    else if (dayOfWeek == "Sunday") pricePerPerson = 16.00;

//    // Apply the "10 people stay free" discount for 100 or more business people
//    if (count >= 100) count -= 10;
//}
//else if (typeOfGroup == "Regular")
//{
//    if (dayOfWeek == "Friday") pricePerPerson = 15.00;
//    else if (dayOfWeek == "Saturday") pricePerPerson = 20.00;
//    else if (dayOfWeek == "Sunday") pricePerPerson = 22.50;

//    // Apply 5% discount if there are between 10 and 20 regular people (inclusive)
//    if (count >= 10 && count <= 20) pricePerPerson *= 0.95;
//}

//// Calculate total price
//double totalPrice = count * pricePerPerson;

//// Output the final price formatted to two decimal places
//Console.WriteLine($"Total price: {totalPrice:f2}");