//Challenge: The Four Sisters and the Duckbear
Console.WriteLine("Enter here the number of egs collected today: ");
int eggsToday = int.Parse(Console.ReadLine());

int numberOfEggsForEachSister = eggsToday / 4;
Console.WriteLine($"Each sister will get {numberOfEggsForEachSister} eggs today.");

int eggsLeft = eggsToday % 4;
Console.WriteLine($"The duckbear will get {eggsLeft} eggs today.");