Console.Clear();
// // Задача № 1, Задайте двумерный массив. НАпишите программу, которая поменяет местами строки 

// int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
// {
//     int[,] newArray = new int [rows, colums]; // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)  // перемещение по рядам;
//     {
//         for (int b = 0; b < colums; b++) // перемещение по строкам
//         {
//             newArray[a, b] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }   // Метод для создания и заполнения двумерного массива
    
// void Show2dArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++) // 0 указывает на строку
//     {
//         for (int b = 0; b < array.GetLength(1); b++) // 1 указывает на столбец
//         {
//             Console.Write(array[a, b] + " ");   // выводит наш массив в терминал "" указывает на пробел в сообщении
//         } // функция Write идет прямо по строке, функция WriteLine Начинает идти с новой строки
//         Console.WriteLine(); // без этой строки массив указывается в одну строку
//     }
//     Console.WriteLine("");    // при необходимости вывода более одного массива, создает пространство между массивами.
// }   // метод для вывода двумерного массива

// int[,] ChangeRows(int[,] array, int row1, int row2) // row 1 и 2 номера строк которые мы хотим заменить
// {
//     row1--;
//     row2--;
//     if ( row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0) // если номера строк выходят за пределы массива или меньше нуля
//         {
//             Console.WriteLine("Invalid rows");  //   то выдает ошибку
//             return array;   // возвращаем не измененный массив
//         }
//     else
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 int temp = array[row1, j]; // во временную запиши значения 1 строки
//                 array[row1, j] = array[row2, j];    // на его место поставь значение из другой строки
//                 array[row2, j] = temp;  // на пустое значение поставь значение из введенной переменной
//             }
//         }
//         return array;   // возвращаем изменненный массив
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row for to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of second row for to chanch: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2dArray(myArray);
// myArray = ChangeRows(myArray, row1, row2);
// Show2dArray(myArray);


// Задача № 2 Задайте двумерный массив. НАпишите программу, которая заменяет строки на столбцы. Если это не возможно то программа должны вывести сообзение для пользователя.


// int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
// {
//     int[,] newArray = new int [rows, colums]; // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)  // перемещение по рядам;
//     {
//         for (int b = 0; b < colums; b++) // перемещение по строкам
//         {
//             newArray[a, b] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }   // Метод для создания и заполнения двумерного массива
    
// void Show2dArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++) // 0 указывает на строку
//     {
//         for (int b = 0; b < array.GetLength(1); b++) // 1 указывает на столбец
//         {
//             Console.Write(array[a, b] + " ");   // выводит наш массив в терминал "" указывает на пробел в сообщении
//         } // функция Write идет прямо по строке, функция WriteLine Начинает идти с новой строки
//         Console.WriteLine(); // без этой строки массив указывается в одну строку
//     }
//     Console.WriteLine("");    // при необходимости вывода более одного массива, создает пространство между массивами.
// }   // метод для вывода двумерного массива

// int[,] RowsToColumns (int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Row and column count mismatch");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp  = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row for to change: ");


// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2dArray(array);
// Show2dArray(RowsToColumns(array));




// Задача № 3 Со

// int [,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
// {
//     int[,] newArray = new int [rows, colums]; // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)  // перемещение по рядам;
//     {
//         for (int b = 0; b < colums; b++) // перемещение по строкам
//         {
//             newArray[a, b] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }   // Метод для создания и заполнения двумерного массива
    
// void Show2dArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++) // 0 указывает на строку
//     {
//         for (int b = 0; b < array.GetLength(1); b++) // 1 указывает на столбец
//         {
//             Console.Write(array[a, b] + " ");   // выводит наш массив в терминал "" указывает на пробел в сообщении
//         } // функция Write идет прямо по строке, функция WriteLine Начинает идти с новой строки
//         Console.WriteLine(); // без этой строки массив указывается в одну строку
//     }
//     Console.WriteLine("");    // при необходимости вывода более одного массива, создает пространство между массивами.
// }   // метод для вывода двумерного массива

// int[,] DeleteMinElement(int[,] array)
// {
//     int min = array[0,0];
//     int rowMin = 0;
//     int columnMin = 0;
// // поиск минимального
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i, j] < min) // поиск минимального значение
//             {
//                 min = array[i, j]; // запомнили их значения
//                 rowMin = i;
//                 columnMin = j;
//             }
//         }
//     }
//     // обнуление столбца
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, columnMin] = 0;
//     }
//     // обнуление строки
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[rowMin, j] = 0;
//     }
//     return array;
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of first row for to change: ");

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2dArray(array);
// Show2dArray(DeleteMinElement(array));



int SumOfRowInArray (int[,] array, int row)
{
    int sumOfRow = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumOfRow += array[row,j];
    }
    return sumOfRow;
}

void MinimumSumOfRowInArray (int[,] array)
{
    int minRow = 0;
    int minimumSumInRow = SumOfRowInArray(array, 0);
    for(int i = 1; i <array.GetLength(0); i++)
    {
        int sum = SumOfRowInArray(array, i);
        if (sum <minimumSumInRow)
        {
            minimumSumInRow = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Row with index {minRow} with minimum sum: {minimumSumInRow} of all members");
}

Строка с индексом имеет минимульную сумму равную стольки то 