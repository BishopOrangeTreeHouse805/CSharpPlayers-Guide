//Challenge: THe Dominion of Kings.
Console.WriteLine("Enter the number of estates you own: ");
int estates = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of duchy you own: ");
int duchy = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of province you own: ");
int provinces = int.Parse(Console.ReadLine());

int total = (estates * 1) + (duchy * 3) + (provinces * 6);

Console.WriteLine($"The total score is {total}.");