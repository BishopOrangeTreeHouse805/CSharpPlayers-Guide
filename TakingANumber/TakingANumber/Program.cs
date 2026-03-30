//Taking a number

int AskForNumber(string text)
{
    while (true)
    {
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        
        Console.WriteLine("Please enter a valid number.");
    }
}



int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        
        if (number > min && number < max)
             {
                 return number;
             }
        Console.WriteLine($"Please enter a number between {min} and {max}: ");
    }
    
}

