namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first num: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second num: ");
        int secondNum = int.Parse(Console.ReadLine());  
        Console.Write("Enter third num: ");
        int thirdNum = int.Parse(Console.ReadLine());
        double harmoniuli = 3.0 / ((1.0 / firstNum) + 1.0 / (secondNum) + 1.0/ (thirdNum));
        Console.WriteLine($"Harmonic mean: {harmoniuli}");
    }
}