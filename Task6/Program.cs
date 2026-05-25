namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("first num ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("second num ");
        int secondNum = int.Parse(Console.ReadLine());
        int usj=1;
        for (int i = firstNum; i <= secondNum * firstNum; i++)
        {
            if (i % firstNum == 0 && i % secondNum == 0)
            {
                usj = i;
                break;
            }
        }
        Console.WriteLine($"The least common multiple is: {usj}");

    }
}