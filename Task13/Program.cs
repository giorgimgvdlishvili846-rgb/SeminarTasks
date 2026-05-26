using System;

namespace Task13;


enum CoinResult
{
    Cifri,
    Borjgalo
}

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int cifriCounter = 0;
        int borjgaloCounter = 0;
        int totalFlips = 1000;

        for (int i = 0; i < totalFlips; i++)
        {
            
            int randomNumber = rnd.Next(0, 2);
            CoinResult result = (CoinResult)randomNumber;

            
            if (result == CoinResult.Cifri)
            {
                cifriCounter++;
            }
            if (result == CoinResult.Borjgalo)
            {
                borjgaloCounter++;
            }
        }

        
        double probability = ((double)borjgaloCounter / totalFlips) * 100;

        Console.WriteLine($"ციფრი მოვიდა: {cifriCounter}-ჯერ");
        Console.WriteLine($"ბორჯღალო მოვიდა: {borjgaloCounter}-ჯერ");
        Console.WriteLine($"ბორჯღალოს მოსვლის ალბათობა: {probability}%");
    }
}