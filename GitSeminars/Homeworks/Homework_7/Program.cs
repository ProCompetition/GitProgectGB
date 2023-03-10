// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// double[,] Create2DRandomArray(int columns, int rows)        // Метод для создания и заполнения двумерного массива; [,]  -  указывает что массив двумерный; columns - столбы, rows - строки; double - значения с плавающей запятой
// {
//     double[,] newArray = new double [rows, columns];        // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)      // перемещение по рядам;
//     {
//         for (int b = 0; b < columns; b++)       // перемещение по строкам
//         {
//             newArray[a,b] = Math.Round(new Random().NextDouble(), 2) +  new Random().Next(1,10);   // Создание и обьедениение псевдорандомных целых и вещественных чисел
//         }
//     }
//     return newArray;        // Завершение метода и возврат значения
// }   
    
// void Show2dArray(double[,] array)       // метод для вывода двумерного массива
// {
//     for (int a = 0; a < array.GetLength(0); a++)        // 0 указывает на строку
//     {
//         for (int b = 0; b < array.GetLength(1); b++)        // 1 указывает на столбец
//         {
//             Console.Write(array[a, b] + " ");        // выводит наш массив в терминал; "" указывает на пробел в сообщении
//         }       // функция Write идет прямо по строке, функция WriteLine Начинает идти с новой строки
//         Console.WriteLine();        // без этой строки массив указывается в одну строку
//     }
//     Console.WriteLine("");      // при необходимости вывода более одного массива, создает пространство между массивами.
// }   

// Console.WriteLine("Input numbers of rows: ");               // запрос указания строк
// int rows = Convert.ToInt32(Console.ReadLine());             // ввод пользователем количества строк
// Console.WriteLine("Input numbers of columns: ");            // запрос указания столбцов
// int columns = Convert.ToInt32(Console.ReadLine());          // ввод пользователем количества столбцов
// // Console.WriteLine("Input minimal value of array element");
// // int minValue = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input maximal value of array element");
// // int maxValue = Convert.ToInt32(Console.ReadLine());
// // Строки 28-35 запрос у пользователя информации

// double [,] array = Create2DRandomArray(rows, columns);
// Show2dArray(array);         // вывод массива в терминал

//_______________________________________________________________________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// int [,] Create2DRandomArray (int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int a = 0; a < rows; a++)
//     {
//         for (int b = 0; b < columns; b++)
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

// void CheckPosition(int[,] array)
// {
//     Console.WriteLine("Введите номер ряда");                              // запрос ввода значения для поиска строки
//     int rows = Convert.ToInt32(Console.ReadLine());                       // ввод значения строки
//     Console.WriteLine("Введите номер столба");                            //  запрос ввода значения для поиска столбца
//     int columns = Convert.ToInt32(Console.ReadLine());                    // ввод значения столбца
//     if (rows > array.GetLength(0) || columns > array.GetLength(1))        // если введеное значение строки превышает длину массива ИЛИ введеное значение столбца превышает высоту массива, то выводится текст
//     {
//         Console.WriteLine($"Введеные координаты {rows} и {columns} располагаются за пределами массива");
//     }
//     else         // иначе выводится результат
//     {
//         Console.WriteLine($"Введеные значения {rows} и {columns} имеет значение {array[rows,columns]}");
//     }
// }


// Console.WriteLine("Input numbers of rows: ");              // запрос указания строк
// int row = Convert.ToInt32(Console.ReadLine());             // ввод пользователем количества строк
// Console.WriteLine("Input numbers of columns: ");           // запрос указания столбцов
// int column = Convert.ToInt32(Console.ReadLine());          // ввод пользователем количества столбцов


// int [,] array = Create2DRandomArray(row, column);
// Show2dArray(array);
// CheckPosition(array);

//_______________________________________________________________________________________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] Create2DRandomArray (int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int a = 0; a < rows; a++)
//     {
//         for (int b = 0; b < columns; b++)
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

// double[] Average (int[,] array) // метод для поиска средних значений
// {
//     double[] average = new double[array.GetLength(1)];
//     for(int a = 0; a<array.GetLength(1); a++)
//     { 
//         double sum = 0;
//         for (int b = 0; b < array.GetLength(0); b++)
//         {
//              sum += array[b , a];
//         }
//         average[a] = sum / array.GetLength(0);
//     }
//     return average;
// }

// void printArray(double[] array) // метод для вывода средних значений
// {
//     Console.Write($"Average value of columns : ");
//     for( int i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.Write($"{array[array.Length-1]}.");
// }

// Console.WriteLine("Input numbers of rows: ");   // запрос указания строк
// int rows = Convert.ToInt32(Console.ReadLine());     // ввод пользователем количества строк
// Console.WriteLine("Input numbers of columns: ");    // запрос указания столбцов
// int columns = Convert.ToInt32(Console.ReadLine());  // ввод пользователем количества столбцов

// int[,] myArray = Create2DRandomArray(rows, columns);
// Show2dArray(myArray);
// printArray(Average(myArray));
