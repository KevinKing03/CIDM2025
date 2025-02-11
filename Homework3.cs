namespace Homework3;

class Program
{
    static void Main()
    {
        Console.Write("Input an integer: ");
        int N = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (N < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
    }
}
