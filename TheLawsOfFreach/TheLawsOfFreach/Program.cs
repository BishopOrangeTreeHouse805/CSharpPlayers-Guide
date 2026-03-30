//The Laws of Freach
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
    
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach (var arrayItem in array)
{
    if (arrayItem < currentSmallest )
        currentSmallest = arrayItem;
}

Console.WriteLine($"The smallest number in the array is {currentSmallest}");

Console.WriteLine("------------------------------------------------------------");

int total = 0;

foreach (var arrayItem in array)
{
    total += arrayItem;
}
float average = (float)total / array.Length;
Console.WriteLine($"The average of thi array is {average}");
