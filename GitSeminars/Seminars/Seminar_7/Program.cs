//     // Task1 

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = new Random().Next(minValue, maxValue+1);
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

// Console.WriteLine("Input please rows quantity of 2way array");
//  int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
//  int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minimum number of 2way array");
//  int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maximum number of 2way array");
//  int max = Convert.ToInt32(Console.ReadLine());

//  int[,] arrayFilled = create2DRandomArray(n, m, min, max);
//  print2DRandomArray(arrayFilled);

//     // Task2

// int[,] create2nmArray(int rows, int columns)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = i + j;
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

// Console.WriteLine("Input please rows quantity of 2way array");
//  int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
//  int m = Convert.ToInt32(Console.ReadLine());

//  int[,] arrayFilled = create2nmArray(n, m);
//  print2DRandomArray(arrayFilled);

    // Task3

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return new2DArray;
// }

// int[,] replaceIfEvenIndex(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             if( i %2 == 0 & j %2 == 0)
//             {array[i,j] =  Convert.ToInt32(Math.Pow(array[i,j],2));};
//         }
//     }
//     return array;
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

// Console.WriteLine("Input please rows quantity of 2way array");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minimum number of 2way array");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maximum number of 2way array");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] arrayFilled = create2DRandomArray(n, m, min, max);
// print2DRandomArray(arrayFilled);
// replaceIfEvenIndex(arrayFilled);
// print2DRandomArray(arrayFilled);

    // Task4

// int[,] create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] new2DArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for( int j = 0; j < columns; j++)
//         {
//             new2DArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return new2DArray;
// }

// void sumOfDiagonale(int[,] array)
// {
//     int totsum = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         totsum += array[i,i];
//     }
//      Console.WriteLine($"Summarize of elements on the main diagonale is {totsum}");
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

// Console.WriteLine("Input please rows quantity of 2way array");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please columns quantity of 2way array");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please minimum number of 2way array");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input please maximum number of 2way array");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] arrayFilled = create2DRandomArray(n, m, min, max);
// print2DRandomArray(arrayFilled);
// sumOfDiagonale(arrayFilled);