
//Challenge: The Defense of Consolas.

Console.WriteLine("Enter the row: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the column: ");
int column = int.Parse(Console.ReadLine());

Console.Beep();
Console.WriteLine($@"Deploy to: 
 ({row    }, {column - 1})
 ({row - 1}, {column    })
 ({row    }, {column + 1})
 ({row + 1}, {column    })
 ");