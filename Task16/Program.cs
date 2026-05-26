using System;

namespace Task16;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String");
        string input = Console.ReadLine();
        Console.WriteLine($"You entered: {input}");
       
        // სანამ სტრინგი ცარიელი არ გახდება
        while (input.Length > 0)
        {
            char ch = input[0]; // ვიღებთ მიმდინარე პირველ სიმბოლოს
            
            int oldLength = input.Length; // ვინახავთ ძველ სიგრძეს
            
            input = input.Replace(ch.ToString(), ""); // ვშლით ამ სიმბოლოს ყველგან
            
            int newLength = input.Length; // ვიგებთ ახალ სიგრძეს
            
            // სხვაობა გვაძლევს ზუსტად იმას, თუ რამდენჯერ შეგვხვდა ეს სიმბოლო
            int counter = oldLength - newLength; 
           
            Console.WriteLine($"The character '{ch}' appears {counter} times in the string.");
        }
    }
}