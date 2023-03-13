Console.Clear();

// // // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // // Например, задан массив:
// // // 1 4 7 2
// // // 5 9 2 3
// // // 8 4 2 4
// // // В итоге получается вот такой массив:
// // // 7 4 2 1
// // // 9 5 3 2
// // // 8 4 4 2

// int [,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;    
// }

// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();    
// }

// void BubbleSort (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             int minPos = j;
//             for (int k = j+1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] < array[i, minPos])
//                 {
//                     minPos = k;
//                 }   
//                 int temp = array[i, k];
//                 array[i, k] = array[i, minPos];
//                 array[i, minPos] = temp;
//             }
//         }
//     }
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2dArray(myArray);
// BubbleSort(myArray);
// // Console.WriteLine("");
// Show2dArray(myArray);


// //-------------------------------------------------------------------------------------------------------------------------------------------------------




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int [,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return newArray;    
// }

// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();    
// }

// int SumRows (int[,] array, int row)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[row, i]; 
//     }
//     return sum;
// }

// void minSumRows (int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = SumRows(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = SumRows(array, i);
//         if (sum < minSumRow)
//         {
//             minSumRow = sum;
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"Строка с индексом {minRow} имеет минимульную сумму равную {minSumRow}");
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray (rows, columns, minValue, maxValue);

// Console.WriteLine("");
// Show2dArray(myArray);
// Console.WriteLine("");
// minSumRows(myArray);


