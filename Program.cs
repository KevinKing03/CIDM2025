namespace Homework2;
class Program
{
    static void Main()
    {
        Console.Write("Please input the first Num: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second Num: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third num: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1; 
            }
            else
            {
                smallest = num3; 
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2; 
            }
            else
            {
                smallest = num3; 
            }
        }

        Console.WriteLine("The smallest value is " + smallest);
    }
}