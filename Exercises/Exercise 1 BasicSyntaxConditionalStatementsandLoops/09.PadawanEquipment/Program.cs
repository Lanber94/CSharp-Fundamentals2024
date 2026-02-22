double balance = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceOflightsabers = double.Parse(Console.ReadLine());
double priceOfrobes = double.Parse(Console.ReadLine());
double priceOfbelts = double.Parse(Console.ReadLine());

double lightsabres =Math.Ceiling(countOfStudents *  1.1);

double belts = countOfStudents - countOfStudents / 6;

double allsum = (lightsabres * priceOflightsabers) + (countOfStudents * priceOfrobes) + (belts * priceOfbelts);


if (allsum <= balance)
{

    Console.WriteLine($"The money is enough - it would cost {allsum:F2}lv.");
}
else
{
    double neededMoney = allsum - balance;
    Console.WriteLine($"John will need {neededMoney:F2}lv more.");
}



//double money = double.Parse(Console.ReadLine()); // Novac koji John ima
//int studentsCount = int.Parse(Console.ReadLine()); // Broj studenata
//double lightsaberPrice = double.Parse(Console.ReadLine()); // Cena lightsabera
//double robePrice = double.Parse(Console.ReadLine()); // Cena ogrtača
//double beltPrice = double.Parse(Console.ReadLine()); // Cena pojasa

//// Računanje potrebnog broja predmeta
//int requiredLightsabers = (int)Math.Ceiling(studentsCount * 1.1); // 2.2 --> Math.Ceiling
//int requiredBelts = studentsCount - studentsCount / 6; // Svaki šesti pojas je besplatan

//// Računanje ukupne cene
//double totalCost = (requiredLightsabers * lightsaberPrice) + (studentsCount * robePrice) + (requiredBelts * beltPrice);

//// Provera da li John ima dovoljno novca
//if (totalCost <= money)
//{
//    Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
//}
//else
//{
//    double neededMoney = totalCost - money;
//    Console.WriteLine($"John will need {neededMoney:F2}lv more.");
//}



