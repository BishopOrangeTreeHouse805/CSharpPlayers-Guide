//Challenge: Number Accumulator Game
Console.WriteLine("How many rounds do you wish play this game? (max is 10)");
int userInput = int.Parse(Console.ReadLine());

if (userInput > 10 && userInput <= 1)
{
    Console.WriteLine("Please enter a number between 1 and 10 (max is 10) and press enter to continue.");
}

