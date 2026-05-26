using System;

namespace Task14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String");
        string input = Console.ReadLine();
        
        bool isPalindrome = true;

       
        for (int i = 0; i < input.Length / 2; i++)
        {
            
            if (input[i] != input[input.Length - 1 - i])
            {
                isPalindrome = false;
                break; 
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("It's a palindrome");
        }
        else
        {
            Console.WriteLine("It's not a palindrome");
        }
    }
}