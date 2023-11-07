using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Display a welcome message for the game
        Console.WriteLine("================================");
        Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        Console.WriteLine("================================");

        // Ask the player to enter their name
        Console.WriteLine("Enter your name:");
        string playerName = Console.ReadLine();

        int playerScore = 0;       // Initialize player's score
        int computerScore = 0;     // Initialize computer's score
        int roundsToWin = 3;       // Set the number of rounds required to win

        Random random = new Random();    // Create a random number generator
        string[] choices = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };  // Define available choices

        // Start the game loop until either player or computer reaches the winning score
        while (playerScore < roundsToWin && computerScore < roundsToWin)
        {
            // Generate the computer's random choice
            string computerChoice = choices[random.Next(choices.Length)];

            // Ask the player to choose their weapon
            Console.WriteLine($"\n{playerName}, choose your weapon: (Rock, Paper, Scissors, Lizard, Spock)");
            string playerChoice = Console.ReadLine();

            // Check if the player's choice is valid
            if (!choices.Contains(playerChoice))
            {
                Console.WriteLine("Invalid choice. Please choose from Rock, Paper, Scissors, Lizard, or Spock.");
                continue;
            }

            // Display the computer's choice
            Console.WriteLine($"Computer chose: {computerChoice}");

            // Determine the winner of the round and update scores
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (
                (playerChoice == "Rock" && (computerChoice == "Scissors" || computerChoice == "Lizard")) ||
                (playerChoice == "Paper" && (computerChoice == "Rock" || computerChoice == "Spock")) ||
                (playerChoice == "Scissors" && (computerChoice == "Paper" || computerChoice == "Lizard")) ||
                (playerChoice == "Lizard" && (computerChoice == "Spock" || computerChoice == "Paper")) ||
                (playerChoice == "Spock" && (computerChoice == "Scissors" || computerChoice == "Rock"))
            )
            {
                Console.WriteLine($"{playerName} wins this round!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computerScore++;
            }

            // Display the current scores
            Console.WriteLine($"{playerName}: {playerScore} - Computer: {computerScore}");
        }

        // Determine and display the overall winner of the game
        if (playerScore > computerScore)
        {
            Console.WriteLine($"\nCongratulations, {playerName}! You win the game!");
        }
        else
        {
            Console.WriteLine("\nComputer wins the game. Better luck next time!");
        }

        // Thank the player for playing
        Console.WriteLine("\nThanks for playing!");
    }
}
