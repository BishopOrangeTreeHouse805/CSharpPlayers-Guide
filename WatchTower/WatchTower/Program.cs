//Challenge: Watchtower
Console.WriteLine("Enter the x - coordinate");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the y - coordinate");
int y = int.Parse(Console.ReadLine());

if (x == 0 && y == 0) Console.WriteLine("The enemy is here!");

if (x > 0 && y > 0)   EnemyCurrentLocation("northeast"); 

if (x > 0 && y < 0)   EnemyCurrentLocation("southeast"); 

if (x == 0 && y > 0 ) EnemyCurrentLocation("north");   

if (x == 0 && y < 0 ) EnemyCurrentLocation("south");

if (x < 0 && y > 0)   EnemyCurrentLocation("northwest");

if (x < 0 && y < 0)   EnemyCurrentLocation("southwest"); 

if (x < 0 && y == 0)  EnemyCurrentLocation("west"); 

if (x > 0 && y == 0)  EnemyCurrentLocation("east");




void EnemyCurrentLocation(string direction)
{
    Console.WriteLine($"The enemy is to the {direction}!");
};