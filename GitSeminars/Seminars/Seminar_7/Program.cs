// // Задача № 1. Задайте двумерный массив размером MxN, заполненный целыми числами.
 
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

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// // Строки 28-35 запрос у пользователя информации

// int [,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Show2dArray(array);


// Задача № 2 
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A=m+n.

// int [,] Create2DArray(int colums, int rows)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
// {
//     int[,] newArray = new int [rows, colums]; // выделение места под массив, размер массива указывается столбцы на строки
//     for (int a = 0; a < rows; a++)  // перемещение по рядам;
//     {
//         for (int b = 0; b < colums; b++) // перемещение по строкам
//         {
//             newArray[a, b] = a+b; // a и b - индексы расположения элемента
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

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// Show2dArray(Create2DArray(colums, rows));

// Задача №3 Задайте двумерный массив. НАйдите элементы, у которых оба индексы четные и замените эти элементы на их квадраты

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

// int[,] FindNum(int[,]array)
// {
//     for(int a = 0; a < array.GetLength(0); a++) //передвигаемся по трокам
//     {
//         for(int b = 0; b < array.GetLength(1); b++) // передвигаемся по столбцам
//         {
//             if (a % 2 == 0 && b % 2 == 0) // определяем четность элементов а и b
//             {
//                 array[a, b] *= array[a, b]; //  если выполняется условие, возводим в квадрат
//                 // array[b] *= array[b];
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

// int[,] MyArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Console.WriteLine();
// Show2dArray(MyArray);
// Console.WriteLine();
// FindNum(MyArray);
// Console.WriteLine();
// Show2dArray(MyArray);



// Задача № 4 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (индексы 0,0 1,1 2,2)

// int [,] Create2DArray(int colums, int rows, int minValue, int maxValue)   // ,-  указывает что массив двумерный, colums - столбы, rows - строки
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

// int FindMainDiagonal(int[,]array)
// {
//     int sum = 0;
//     for (int a = 0; a < array.GetLength(0); a++) //передвигаемся по трокам
//     {
//         for (int b = 0; b < array.GetLength(1); b++) // передвигаемся по столбцам
//         {
//             if (a == b) sum = array[a, b] + sum;
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Input numbers of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input numbers of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Create2DArray(colums, rows, minValue, maxValue);
// Show2dArray(MyArray);
// FindMainDiagonal(MyArray); // ошибка
// Console.WriteLine(FindMainDiagonal(MyArray));
