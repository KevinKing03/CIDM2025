namespace Homework3;

class Program
{
    static void Main()
    {
        Console.Write("Input an integer N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
