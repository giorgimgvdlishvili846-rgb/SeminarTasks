using System;

namespace Task11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int n = int.Parse(Console.ReadLine());
        int reversed = reverse(n);
        
        Console.WriteLine(reversed); 
    }

    static int reverse(int n)
    {
        int result = 0;

        while (n != 0)
        {
            int rest = n % 10;     
            result = result * 10 + rest; 
            n = n / 10;   
        }

        return result;
    }
}