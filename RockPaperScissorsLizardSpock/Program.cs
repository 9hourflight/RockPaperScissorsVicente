namespace RockPaperScissorsLizardSpock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] handOptions = { "rock", "paper", "scissors", "lizard", "spock" };
            Random generateHand = new Random();
            Console.WriteLine("Please enter one of the following options to begin: rock, paper, scissors, lizard, spock");
            string? userInput = Console.ReadLine();
            string? inputCaseCorrected = userInput.ToLower();
            string computerChoice = handOptions[generateHand.Next(0, 5)];
            //Console.WriteLine("The computer chose " + computerChoice]);
            if (inputCaseCorrected != null)
            {
                CheckValid(inputCaseCorrected);
            }
        }
        static void CheckValid(string user)
        {
            switch (user)
            {
                case "rock":
                    break;
                case "paper":
                    break;
                case "scissors":
                    break;
                case "lizard":
                    break;
                case "spock":
                    break;
                default:
                    Console.WriteLine("Please enter one of the following options to begin: rock, paper, scissors, lizard, spock");
                    break;

            }
            
        }
        
    }
}
