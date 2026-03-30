//The Replicator of D'To

int[] numberArray = new int[5];


for (int i = 0; i < numberArray.Length; i++)
{
    int userInput = int.Parse(Console.ReadLine());
    numberArray[i] = userInput;
}


int[] duplicateArray = new int[5];

for (int i = 0; i < duplicateArray.Length; i++)
{
    duplicateArray[i] = numberArray[i];
}

Console.WriteLine("\n Index | Original | Duplicate");
Console.WriteLine(" ------|----------|----------");

for (int i = 0; i < numberArray.Length; i++)
{
    Console.WriteLine($"  [{i}]  |    {numberArray[i],-6}|    {duplicateArray[i]}");
}