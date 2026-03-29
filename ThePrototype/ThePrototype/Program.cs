//Challenge: The Prototype

int user1Number;
while (true)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    if (int.TryParse(Console.ReadLine().Trim(), out user1Number) && user1Number >= 0 &&  user1Number <= 100)
        break;
    
    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
}

Console.Clear();

while (true)
{
    Console.Write("User 2, guess the number of User 1 (0-100): ");
    if (!int.TryParse(Console.ReadLine().Trim(), out int user2Number ))
    {
        Console.WriteLine("Invalid input. Please enter number.");
        continue;
    }

    if (user2Number == user1Number) { Console.WriteLine("You win!"); break; }
    else if (user2Number > user1Number) { Console.WriteLine("Too high.");}
    else {Console.WriteLine("Too low."); }
}