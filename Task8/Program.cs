namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("first num ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("second num ");
        int secondNum = int.Parse(Console.ReadLine());
        int usg=1;
        for (int i = firstNum; i >=1; i--)
        {
            if (firstNum %i  == 0 && secondNum % i == 0)
            {
                usg = i;
                break;
            }
        }
        Console.WriteLine($"უსგ : {usg}");

    }
}