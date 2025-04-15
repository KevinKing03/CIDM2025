using System;

class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.Write("Enter your move (Rock, Paper, Scissors): ");
        return Console.ReadLine().Trim().ToLower();
    }
}

class ComputerPlayer
{
    private static readonly string[] choices = { "rock", "paper", "scissors" };
    private Random random = new Random();

    public string ComputerDecision()
    {
        int index = random.Next(choices.Length);
        return choices[index];
    }
}

class RockPaperScissors
{
    static void Main(string[] args)
    {
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (human.GetPoints() > 0)
        {
            Console.WriteLine($"\nCurrent points: {human.GetPoints()}");
            string humanMove = human.HumanDecision();
            string computerMove = computer.ComputerDecision();

            Console.WriteLine($"Computer chose: {computerMove}");

            if (humanMove == computerMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (humanMove == "rock" && computerMove == "scissors") ||
                (humanMove == "paper" && computerMove == "rock") ||
                (humanMove == "scissors" && computerMove == "paper"))
            {
                Console.WriteLine("You win this round!");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You lose this round.");
                human.LoseRound();
            }

            Console.WriteLine($"Updated points: {human.GetPoints()}");

            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("Game over. You have 0 points left.");
                break;
            }

            Console.Write("Play another round? (yes/no): ");
            string choice = Console.ReadLine().Trim().ToLower();
            if (choice != "yes")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }
}