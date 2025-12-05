// // // // //  //HP Tracker
// // // // //  Console.WriteLine("Hello, World!");
// // // // //
// // // // //  //What comes next?
// // // // //  Console.WriteLine("What comes next?");
// // // // //
// //
// //
// // //--------------------------------------------------------------------
// //
// // // // //  //The Making of a Programmer 
// // // // //  Console.WriteLine("The Making of a Programmer");
// // // // //  Console.WriteLine("Programming is a super power");
// // // // //  Console.WriteLine("I love programming");
// // // // //  Console.WriteLine("Tik tok tik tok");
// // // // //  Console.WriteLine("I kick ass.");
// // // // //
// //
// //
// // //--------------------------------------------------------------------
// //
// // // // //  //Consolas and Telim
// // // // //  Console.WriteLine("Bread is ready.");
// // // // //  Console.WriteLine("Who is this bread for?");
// // // // //  string breadFor = Console.ReadLine();
// // // // //  Console.WriteLine($"Noted: {breadFor} got bread.");
// //
// //
// // //--------------------------------------------------------------------
// //
// // // // // //The Things Namer 3000
// // // // // Console.WriteLine("What kind of thing are we talking about?");
// // // // // string nameOfTheThing = Console.ReadLine();
// // // // // Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// // // // // string DescriptionOfTheThing = Console.ReadLine();
// // // // // string doom = "Doom";
// // // // // string thingVersion = "3000";
// // // // // Console.WriteLine("The "+ DescriptionOfTheThing + " " + nameOfTheThing + " of " + doom + " " + thingVersion );
// // // //
// // // //
// // //--------------------------------------------------------------------
// //
// // // // //The Variable Shop and The Variable Shop Returns.
// // // // char letter = 't';
// // // // string term = "San Clemente";
// // // // bool isDenied = true;
// // // // float fraction = 1.70f;
// // // // double ratio = 2.4556;
// // // // decimal money = 3000.00m;
// // // // int number = -50;
// // // // uint digit = 6;
// // // // long distance = 5000000;
// // // // ulong distance2 = 5000001;
// // // // short balance = 31;
// // // // ushort debt = 46;
// // // // byte age = 5;
// // // // sbyte acceleration = -1;
// // // //
// // // //
// // // // Console.WriteLine(letter);
// // // // Console.WriteLine(term);
// // // // Console.WriteLine(isDenied);
// // // // Console.WriteLine(fraction);
// // // // Console.WriteLine(ratio);
// // // // Console.WriteLine(money);
// // // // Console.WriteLine(number);
// // // // Console.WriteLine(digit);
// // // // Console.WriteLine(distance);
// // // // Console.WriteLine(distance2);
// // // // Console.WriteLine(balance);
// // // // Console.WriteLine(debt);
// // // // Console.WriteLine(age);
// // // // Console.WriteLine(acceleration);
// // // //
// // //--------------------------------------------------------------------
// //
// // // //The Triangle Farmer
// // // Console.WriteLine("What is the base of the triangle?");
// // // float baseOfTriangle = float.Parse(Console.ReadLine());
// // // Console.WriteLine("What is the height of the triangle?");
// // // float heightOfTriangle = float.Parse(Console.ReadLine());
// // //
// // //
// // // float areaOfTriangle = baseOfTriangle * heightOfTriangle / 2;
// // //
// // // Console.WriteLine($"The area of the triangle with a base of {baseOfTriangle} and height of {heightOfTriangle} is {areaOfTriangle}");
// // //
// // //--------------------------------------------------------------------
// // //
// // // //Challenge: The Four Sisters and the Duckbear
// // // Console.WriteLine("Enter here the number of egs collected today: ");
// // // int eggsToday = int.Parse(Console.ReadLine());
// // //
// // // int numberOfEggsForEachSister = eggsToday / 4;
// // // Console.WriteLine($"Each sister will get {numberOfEggsForEachSister} eggs today.");
// // //
// // // int eggsLeft = eggsToday % 4;
// // // Console.WriteLine($"The duckbear will get {eggsLeft} eggs today.");
// //
// // //--------------------------------------------------------------------
// // //Challenge: THe Dominion of Kings. 
// // Console.WriteLine("Enter the number of estates you own: ");
// // int estates = int.Parse(Console.ReadLine());
// //
// // Console.WriteLine("Enter the number of duchy you own: ");
// // int duchy = int.Parse(Console.ReadLine());
// //
// // Console.WriteLine("Enter the number of province you own: ");
// // int provinces = int.Parse(Console.ReadLine());
// //
// // int total = (estates * 1) + (duchy * 3) + (provinces * 6);
// //
// // Console.WriteLine($"The total score is {total}.");
//
//
// // //--------------------------------------------------------------------
// //Challenge: The Defense of Consolas.
//
// using System.Data;
// //Challenge: The Defense of Consolas.
// // Console.WriteLine("Enter the row: ");
// // int row = int.Parse(Console.ReadLine());
// //
// // Console.WriteLine("Enter the column: ");
// // int column = int.Parse(Console.ReadLine());
// //
// // Console.Beep();
// // Console.WriteLine($@"Deploy to: 
// // ({row    }, {column - 1})
// // ({row - 1}, {column    })
// // ({row    }, {column + 1})
// // ({row + 1}, {column    })
// // ");
//
//
// //Challenge: Repairing the Clock Tower
// // Console.WriteLine("Enter the clock time number: ");
// // int numericInput = int.Parse(Console.ReadLine());
// //
// // string clockSound = numericInput % 2 == 0
// //     ? "Tick"
// //     : "Tock";
// //     
// // Console.WriteLine(clockSound);
//
// //Challenge: Watchtower
// Console.WriteLine("Enter the x - coordinate");
// int x = int.Parse(Console.ReadLine());
//
// Console.WriteLine("Enter the y - coordinate");
// int y = int.Parse(Console.ReadLine());
//
// if (x == 0 && y == 0) Console.WriteLine("The enemy is here!");
//
// if (x > 0 && y > 0)   EnemyCurrentLocation("northeast"); 
//
// if (x > 0 && y < 0)   EnemyCurrentLocation("southeast"); 
//
// if (x == 0 && y > 0 ) EnemyCurrentLocation("north");   
//
// if (x == 0 && y < 0 ) EnemyCurrentLocation("south");
//
// if (x < 0 && y > 0)   EnemyCurrentLocation("northwest");
//
// if (x < 0 && y < 0)   EnemyCurrentLocation("southwest"); 
//
// if (x < 0 && y == 0)  EnemyCurrentLocation("west"); 
//
// if (x > 0 && y == 0)  EnemyCurrentLocation("east");
//
//
//
//
// void EnemyCurrentLocation(string direction)
// {
//     Console.WriteLine($"The enemy is to the {direction}!");
// };


//Challenge: Buying Inventory
Console.WriteLine($@"The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int itemChoiceNumber))
{
    Console.WriteLine("Invalid input. Please enter a number.");
    return;
}

string? item = itemChoiceNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => null
};

if (item == null)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
    return;
}

byte itemGoldPrice = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1,
    _ => throw new Exception("Invalid Action. Please contact support.")
};

Console.WriteLine($"{item} costs {itemGoldPrice} gold.");
//Challenge: Discounted Inventory


//Challenge: The Prototype


//Challenge: The Magic Cannon