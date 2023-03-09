// Задачи для самостоятельной проверки

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Задача, необходимо ввести два числа (A и B), программа должна возвести число А в степень В");
// Console.WriteLine("Input number A");                   // Запрашиваем у пользователя число
// Double numA = Convert.ToInt32(Console.ReadLine());       // Записываем пользовательское число 
// Console.WriteLine("Input number B");
// Double numB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{numA}^{numB} = {(long)Math.Pow(numA, numB)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Задача, необходимо ввести число, в результате получим сумму цифр этого числа");
// Console.WriteLine("Введите число"); 
// int num = int.Parse(Console.ReadLine());
//             int sum = 0;
//             while (num > 0)
//             {
//                 sum = sum + num % 10;
//                 num = num /10 ; 
//             }
// Console.WriteLine($"Сумма цифр в заданном числе = {sum}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maximum value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// ShowArray(myArray);