using System.Security.Cryptography;

namespace RockPaperScissorsLizardSpock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int computerPoints = 0;
            bool canPlayNextRound = true;
            string[] handOptions = { "rock", "paper", "scissors", "lizard", "spock" };
            Random generateHand = new Random();
            Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock! Score five points to win!");
            while (canPlayNextRound)
            {
                Console.WriteLine("Please enter one of the following options to begin: rock, paper, scissors, lizard, spock");
                string? userInput = Console.ReadLine();
                string? inputCaseCorrected = userInput.ToLower();
                string computerChoice = handOptions[generateHand.Next(0, 5)];
                CheckValidAndCompete(userInput, inputCaseCorrected, computerChoice, ref playerPoints, ref computerPoints);
                if (playerPoints == 5)
                {
                    canPlayNextRound = false;
                    Console.WriteLine("You win!");
                }
                else if (computerPoints == 5)
                {
                    canPlayNextRound = false;
                    Console.WriteLine("You lose!");
                }
            }
        }
        static void CheckValidAndCompete(string user, string caseSensitive, string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (user)
            {
                case "rock":
                    Console.WriteLine("You chose rock");
                    UserRock(cpuHand, ref playerScore, ref cpuScore);
                    break;
                case "paper":
                    UserPaper(cpuHand, ref playerScore, ref cpuScore);
                    break;
                case "scissors":
                    UserScissors(cpuHand, ref playerScore, ref cpuScore);
                    break;
                case "lizard":
                    UserLizard(cpuHand, ref playerScore, ref cpuScore);
                    break;
                case "spock":
                    UserSpock(cpuHand, ref playerScore, ref cpuScore);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;

            }

        }
        static void UserRock(string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (cpuHand)
            {
                case "rock":
                    Console.WriteLine("Opponent chose rock. It's a draw");
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "paper":
                    Console.WriteLine("Opponent chose paper. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "scissors":
                    Console.WriteLine("Opponent chose scissors. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "lizard":
                    Console.WriteLine("Opponent chose lizard. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "spock":
                    Console.WriteLine("Opponent chose spock. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
            }
        }

        static void UserScissors(string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (cpuHand)
            {
                case "rock":
                    Console.WriteLine("Opponent chose rock. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "paper":
                    Console.WriteLine("Opponent chose paper. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "scissors":
                    Console.WriteLine("Opponent chose scissors. It's a draw");
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "lizard":
                    Console.WriteLine("Opponent chose lizard. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "spock":
                    Console.WriteLine("Opponent chose spock. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
            }
        }

        static void UserPaper(string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (cpuHand)
            {
                case "rock":
                    Console.WriteLine("Opponent chose rock. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "paper":
                    Console.WriteLine("Opponent chose paper. It's a draw");
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "scissors":
                    Console.WriteLine("Opponent chose scissors. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "lizard":
                    Console.WriteLine("Opponent chose lizard. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "spock":
                    Console.WriteLine("Opponent chose spock. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
            }
        }
        static void UserLizard(string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (cpuHand)
            {
                case "rock":
                    Console.WriteLine("Opponent chose rock. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "paper":
                    Console.WriteLine("Opponent chose paper. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "scissors":
                    Console.WriteLine("Opponent chose scissors. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "lizard":
                    Console.WriteLine("Opponent chose lizard. It's a draw");
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "spock":
                    Console.WriteLine("Opponent chose spock. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
            }
        }

        static void UserSpock(string cpuHand, ref int playerScore, ref int cpuScore)
        {
            switch (cpuHand)
            {
                case "rock":
                    Console.WriteLine("Opponent chose rock. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "paper":
                    Console.WriteLine("Opponent chose paper. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "scissors":
                    Console.WriteLine("Opponent chose scissors. You win");
                    playerScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "lizard":
                    Console.WriteLine("Opponent chose lizard. You lose");
                    cpuScore++;
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
                case "spock":
                    Console.WriteLine("Opponent chose spock. It's a draw");
                    Console.WriteLine("You: " + playerScore + " Opponent: " + cpuScore);
                    break;
            }
        }
    }
}
