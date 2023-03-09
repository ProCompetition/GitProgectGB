// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int colums, int rows)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
// {
//     double[,] newArray = new double [rows, colums]; // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)  // перемещение по рядам;
//     {
//         for (int b = 0; b < colums; b++) // перемещение по строкам
//         {
//             newArray[a,b] = Math.Round(new Random().NextDouble(), 2) +  new Random().Next(1,10);
//         }
//     }
//     return newArray;
// }   // Метод для создания и заполнения двумерного массива
    
// void Show2dArray(double[,] array)
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

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input minimal value of array element");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input maximal value of array element");
// // int maxValue = Convert.ToInt32(Console.ReadLine());
// // Строки 28-35 запрос у пользователя информации

// double [,] array = Create2DRandomArray(rows, colums);
// Show2dArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int [,] Create2DRandomArray (int rows, int colums)
{
    int[,] newArray = new int[rows, colums];
    for (int a = 0; a < rows; a++)
    {
        for (int b = 0; b < colums; b++)
        {
            newArray[a,b] = new Random().Next(1, 10);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a,b]+ " ");
        }
        Console.WriteLine(" ");
    }
}

void CheckPosition(int[,] array)
{
    Console.WriteLine("Введите номер ряда");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столба");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows>array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine($"Введеные значения {rows} и {columns} располагаются за пределами массива");
    }
    else
    {
        Console.WriteLine($"Введеные значения {rows} и {columns} имеет значение {array[rows,columns]}");
    }
}



Console.WriteLine("Input numbers of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of colums: ");
int column = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2DRandomArray(row, column);
Show2dArray(array);
CheckPosition(array);








// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] Create2DRandomArray (int rows, int colums)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int a = 0; a < rows; a++)
//     {
//         for (int b = 0; b < colums; b++)
//         {
//             newArray[a,b] = new Random().Next(1, 10);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int a = 0; a < array.GetLength(0); a++)
//     {
//         for (int b = 0; b < array.GetLength(1); b++)
//         {
//             Console.Write(array[a,b]+ " ");
//         }
//         Console.WriteLine(" ");
//     }
// }

// double[] Average (int[,] array)
// {
//     double[] average = new double[array.GetLength(1)];
//     for(int a = 0; a<array.GetLength(1); a++)
//     { 
//         double sum = 0;
//         for (int b = 0; b < array.GetLength(0); b++)
//         {
//              sum += array[a , b];
//         }
//         average[a] = sum / array.GetLength(0);
//     }
//     return average;
// }

// void printArray(double[] array)
// {
//     Console.Write($"Average value of columns : ");
//     for( int i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.Write($"{array[array.Length-1]}.");
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, colums);
// Show2dArray(myArray);
// printArray(Average(myArray));
