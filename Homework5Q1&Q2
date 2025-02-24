namespace Homework5;

class Program
{
    static int GetLargestOfTwo(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int GetLargestOfFour(int a, int b, int c, int d)
    {
        int max1 = GetLargestOfTwo(a, b);
        int max2 = GetLargestOfTwo(c, d);
        return GetLargestOfTwo(max1, max2);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int largestTwo = GetLargestOfTwo(num1, num2);
        Console.WriteLine("The largest number is: " + largestTwo);

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        int num4 = int.Parse(Console.ReadLine());

        int largestFour = GetLargestOfFour(num1, num2, num3, num4);
        Console.WriteLine("The largest number is: " + largestFour);
    }
}
