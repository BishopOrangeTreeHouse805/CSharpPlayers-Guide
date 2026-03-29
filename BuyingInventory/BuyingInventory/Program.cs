//BuyingInventory
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

double itemGoldPrice = item switch
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

Console.Write("Please enter your first name: ");
string name = Console.ReadLine().Trim().ToLower();

if (name == "john") { itemGoldPrice /= 2;}

Console.WriteLine($"{item} costs {itemGoldPrice} gold.");
