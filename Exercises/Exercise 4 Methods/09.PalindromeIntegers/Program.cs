using System;

class Program
{
    static void Main()
    {
        string numberAsString;
        while ((numberAsString = Console.ReadLine()) != "END")
        {
            bool isPalindrome = IsPalindrome(numberAsString);//True, False
            Console.WriteLine(isPalindrome);
            //Console.WriteLine(isPalindrome.ToString().ToLower()); true, false
        }
    }

    static bool IsPalindrome(string numberStr)
    {
        string reversedStr = Reverse(numberStr);
      
        if (reversedStr == numberStr)
        {
            return true;
        }
        return false;
    }

    static string Reverse(string textForReverse)
    {
        char[] arr = textForReverse.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        return reversed;
    }
}