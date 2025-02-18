namespace Homework4;

class Program
{
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N is: {N}; shape is {shape}");

        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i));
            }
        }
        else
        {
            Console.WriteLine("Invalid shape! Please use 'left' or 'right'.");
        }
    }

    static void Main()
    {
        PrintTriangle(5, "left");

        Console.WriteLine(); 

        PrintTriangle(5, "right");
    }
}