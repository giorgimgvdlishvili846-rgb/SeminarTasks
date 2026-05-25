namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());

        
        int result = fibonnaci(n);
        if (result != -1) 
        {
            Console.WriteLine($"Fibonacci number at position {n} is: {result}");
        }

        
        static int fibonnaci(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("invalid");
                return -1; 
            }

           
            if (n == 1 || n == 2)
            {
                return 1;
            }
            
            
            return fibonnaci(n - 1) + fibonnaci(n - 2);
        }
    }
}