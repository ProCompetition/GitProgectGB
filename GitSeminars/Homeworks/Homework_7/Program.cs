// //     // Task47

// double[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] new2DArray = new double[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = Math.Round(new Random().NextDouble(), 2) +  new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }

// Console.WriteLine("Input please rows quantity of 2way array");
//  int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minimum number of 2way array");
//  int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maximum number of 2way array");
//  int max = Convert.ToInt32(Console.ReadLine());

//  double[,] arrayFilled = create2DRandomArray(n, m, min, max);
//  print2DRandomArray(arrayFilled);

//     // Task50

// int[,] create2DRandomArray(int rows, int columns)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] =  new Random().Next(1, 100);
//         }
//     }
//     return new2DArray;
// }

// void print2DRandomArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine("");

//     }
// }

// void checkMember (int[,] array)
// {
//     Console.WriteLine("Input please row number of member");
//     int rowMember = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input please column number of member");
//     int columnMember = Convert.ToInt32(Console.ReadLine());
//     if(rowMember > array.GetLength(0) || columnMember > array.GetLength(1))
//     {
//         Console.WriteLine($"Mebmer {rowMember}:{columnMember} is out of array");
//     }
//     else
//     {
//         Console.WriteLine($"Mebmer with adress {rowMember}:{columnMember} started from 0 is {array[rowMember, columnMember]} ");
//    }
// }

// Console.WriteLine("Input please rows quantity of 2way array");
//  int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
//  int m = Convert.ToInt32(Console.ReadLine());

// int[,] arrayFilled = create2DRandomArray(n, m);
// print2DRandomArray(arrayFilled);
// checkMember(arrayFilled);

    // Task52

int[,] create2DRandomArray(int rows, int columns)
{
    int[,] new2DArray = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            new2DArray[i,j] =  new Random().Next(1, 100);
        }
    }
    return new2DArray;
}

void print2DRandomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");

    }
}

double[] AverColumnInArray (int[,] array)
{
    double[] averColumnInArray = new double[array.GetLength(1)];
    for(int i = 0; i <array.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        averColumnInArray[i] = sum / array.GetLength(0);
    }
    return averColumnInArray;
}

void printArray(double[] array)
{
    Console.Write($"Average of all members in columns are : ");
    for( int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length-1]}.");
}

Console.WriteLine("Input please rows quantity of 2way array");
 int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please columns quantity of 2way array");
 int m = Convert.ToInt32(Console.ReadLine());

int[,] arrayFilled = create2DRandomArray(n, m);
print2DRandomArray(arrayFilled);
printArray(AverColumnInArray(arrayFilled));