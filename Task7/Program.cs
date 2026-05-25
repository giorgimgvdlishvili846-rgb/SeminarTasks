namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("first num ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("second num ");
        int secondNum = int.Parse(Console.ReadLine());
        int nxarisxadm = 1;
        for (int i = 1; i <= secondNum; i++)
        {
         nxarisxadm=nxarisxadm*firstNum;
            
        }
        Console.WriteLine($"The least common multiple is: {nxarisxadm}");

    }
}