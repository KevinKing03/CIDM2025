namespace Homework4;

class Program
{
    static int GetLargestNumber(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    static void Main()
    {
        int a = 3, b = 5;
        int largest = GetLargestNumber(a, b);

        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}
