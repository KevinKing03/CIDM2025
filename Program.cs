namespace Homework2;
class Program
{
    static void Main()
    {
        //code for Q1
        Console.Write("Please input letter grade: ");
        string grade = Console.ReadLine().ToUpper(); 

        switch (grade)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong letter grade!");
                break;
                
        }
    }
}