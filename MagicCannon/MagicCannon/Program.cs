//Challenge: The Magic Cannon

Console.WriteLine("Turn the crank to fire the Magic Cannon!");
Console.WriteLine("Press Escape to stop the crank.");

for(int crankTurn = 1; crankTurn <= 100; crankTurn++)
{
    ConsoleKeyInfo key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Escape) break;
    
    string blastType;

    if (crankTurn % 3 == 0 && crankTurn % 5 == 0)
    {
        blastType = "Fire and Electric";
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    else if (crankTurn % 3 == 0)
    {
        blastType = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;

    }
    else if (crankTurn % 5 == 0)
    {
        blastType = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        blastType = "Normal";
        Console.ForegroundColor = ConsoleColor.Gray;
        
    }
    
    Console.WriteLine($"{crankTurn}: {blastType}");


    if (crankTurn == 100) crankTurn = 0;
}


