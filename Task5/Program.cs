namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the  number: ");
        int number = int.Parse(Console.ReadLine());
        int divisions = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisions++;
            }
        }
        Console.WriteLine($"The divisions are: {divisions}");
    }
}