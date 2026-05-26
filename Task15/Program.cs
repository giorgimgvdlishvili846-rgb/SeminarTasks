namespace Task15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the String");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the char");
        char myChar = Console.ReadLine()[0];
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == myChar)
            {
                counter++;
            }
        }
        Console.WriteLine($"The character '{myChar}' appears {counter} times in the string.");
    }
}