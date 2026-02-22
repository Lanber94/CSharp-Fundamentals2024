string user = Console.ReadLine();
string login = "";
while (true)
{
    for (int i = user.Length - 1; i >= 0; i--)
    {
        login += user[i];
    }

    for (int i = 1; i <= 4; i++)
    {
        string password = Console.ReadLine();
        if (login == password)
        {
            Console.WriteLine($"User {user} logged in.");
            return;
        }

        if (i == 4)
        {
            Console.WriteLine($"User {user} blocked!");
            return;
        }
        Console.WriteLine("Incorrect password. Try again.");
    }
}


//-----------------------------//-------------------------------//------------------------------------------//


//string user = Console.ReadLine();
//string correctPassword = "";


//for (int i = user.Length - 1; i >= 0; i--)
//{
//    correctPassword += user[i];
//}


//int attempts = 0;


//while (attempts < 4)
//{
//    string login = Console.ReadLine();  
//    attempts++;

//    if (login == correctPassword)  
//    {
//        Console.WriteLine($"User {user} logged in.");
//        return;  
//    }
//    else
//    {
//        if (attempts < 4)  
//        {
//            Console.WriteLine("Incorrect password. Try again.");
//        }
//    }
//}

//Console.WriteLine($"User {user} blocked!");


