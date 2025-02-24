namespace Homework5;

class Program
{
    static bool CheckAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password1 = Console.ReadLine();

        Console.Write("Re-enter password: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear;
        
        while (!int.TryParse(Console.ReadLine(), out birthYear))
        {
            Console.Write("Invalid input. Please enter a valid birth year: ");
        }

        if (CheckAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully.");
            }
            else
            {
                Console.WriteLine("Wrong password.");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
        }
    }

    static void Main()
    {
        CreateAccount();
    }
}