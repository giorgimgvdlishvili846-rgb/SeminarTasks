namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        while (true)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                counter++;
            }
            if (number == -1)
            {
                break;
            }
        }
        Console.WriteLine($"The even numbers are: {counter}");
    }
}