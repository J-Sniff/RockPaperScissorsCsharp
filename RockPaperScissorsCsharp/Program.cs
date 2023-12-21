using System;

namespace RockPaperScissorsCsharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int playerScore = 0;
			int computerScore = 0;

			Random random = new Random();

			Console.WriteLine("Welcome to Rock Paper Scissors!");
			Console.WriteLine("Please enter R for rock");
			Console.WriteLine("Please enter P for paper");
			Console.WriteLine("Please enter S for scissors");

			while (playerScore != 3 && computerScore != 3)
			{
				Console.WriteLine($"Player score: {playerScore}");
				Console.WriteLine($"Computer score: {computerScore}");				

				string playerChoice = Console.ReadLine().ToLower();
				int computerChoice = random.Next(0, 3);

				if (computerChoice == 0)
				{
					Console.WriteLine("Computer has chosen rock");

					switch (playerChoice)
					{
						case "r":
							Console.WriteLine("It's a tie!");
							break;
						case "p":
							Console.WriteLine("Player wins this round.");
							playerScore++;
							break;
						default:
							Console.WriteLine("Computer wins this round.");
							computerScore++;
							break;
					}
				}
				else if (computerChoice == 1)
				{
					Console.WriteLine("Computer has chosen paper");

					switch (playerChoice)
					{
						case "r":
							Console.WriteLine("Computer wins this round.");
							computerScore++;
							break;
						case "p":
							Console.WriteLine("It's a tie!");
							break;
						default:
							Console.WriteLine("You win this round.");
							playerScore++;
							break;
					}
				}
				else
				{
					Console.WriteLine("Computer has chosen scissors");

					switch (playerChoice)
					{
						case "r":
							Console.WriteLine("You win this round.");
							playerScore++;
							break;
						case "p":
							Console.WriteLine("Computer wins this round.");
							computerScore++;
							break;
						default:
							Console.WriteLine("It's a tie!");
							break;
					}
				}
			}

			if (playerScore == 3)
			{
                Console.WriteLine("Congratulations you win!");
            }
			else
			{
                Console.WriteLine("Sorry you lose!");
            }

			Console.ReadKey();
		}
	}
}
