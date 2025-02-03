namespace Homework2;
class Program
{
    static void Main()
    {
        // Ask the user for a year input
        Console.Write("Please enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        // Check if the year is a leap year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}
