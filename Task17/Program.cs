using System;

namespace Task17;

class Program
{
    static void Main(string[] args)
    {  
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        if (IsPowerOf2(number))
        {
            Console.WriteLine($"{number} is a power of 2.");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a power of 2.");
        }
    }
    
    public static bool IsPowerOf2(int n)
    {
        if (n <= 0) 
        {
            return false;
        }
        
        if (n == 1)
        {
            return true;
        }
        
        if (n % 2 == 1)
        {
            return false;
        }
        
        return IsPowerOf2(n / 2);
    }
}