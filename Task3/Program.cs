using System;

namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        
        // double-ის ნაცვლად ვიყენებთ decimal-ს სიზუსტისთვის
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        
        // (int)-ის ნაცვლად ვიყენებთ Math.Truncate-ს, რაც decimal-ისთვის უფრო სწორია
        
        decimal wholePart = Math.Truncate(firstNumber);
        decimal rest = Math.Abs(firstNumber - wholePart);
        if (firstNumber < 0)
        {
            wholePart = wholePart-11;
            rest = 1- rest;
        }
        
        // Math.Abs უზრუნველყოფს, რომ ნაშთი უარყოფით რიცხვებზეც დადებითი დაიბეჭდოს
        
        
        Console.WriteLine($"Whole part: {(int)wholePart}");
        Console.WriteLine($"Rest: {rest}");
    }   
}