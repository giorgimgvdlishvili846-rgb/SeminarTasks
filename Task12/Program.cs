using System.Diagnostics.Metrics;

namespace Task12;

class Program
{

    static void Main(string[] args)
    {
        int n = 1000;
        for(int i=1; i<=n; i++)
        {
            if (Isprime(i))
            {
                Console.WriteLine(i);
            }
        }











    }

    static bool Isprime(int n)
    {
        int Counter = 0;
        for (int i = 2; i < n; i++)
        {

            if (n % i == 0)
            {
                Counter ++;
                

            }
        }

        if (Counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}  