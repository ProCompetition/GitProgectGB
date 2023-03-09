//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] ReverseArray (int[] array)
// {
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1]; 
//         array[array.Length - i - 1] = temp;
//     }

//     return array;

// }


// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// int [] reversedArray = ReverseArray(myArray);
// ShowArray(reversedArray);

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины самое важное знать правило, 
// каждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle(int x, int y, int z)
// {
//     if(x<y+z && y<z+x && z<x+y)
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Input langht of a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input langht of b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input langht of c");
// int c = Convert.ToInt32(Console.ReadLine());

// // bool result = CheckTriangle(a, b, c);
// Console.WriteLine($"Does such triangle with sides {a} and {b} and {c} exist? {CheckTriangle(a,b,c)}");



//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// моя запись решения задачи с ошибкой


// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Fibonacci(int size, int a, int b);
// {
//     int[] myArray = new int[size];
//     myArray[0] = a;
//     myArray[1] = b;
//     for (int i = 2; i < myArray.Length; i++)
//     {
//         myArray[i] = myArray[i-1] + myArray[i-2];
//     }
//     return myArray;
// }

// Console.WriteLine("Input size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size b");
// int b = Convert.ToInt32(Console.ReadLine());

// // ShowArray(myArray);
// int[] fibonacci = Fibonacci(size, a, b);
// ShowArray(fibonacci);


// запись решения комнаты без ошибки

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Fibonacci ( int size, int a, int b)
// {
//     int[] myArray = new int[size];
//     myArray[0] = a;
//     myArray[1] = b;
//     for (int i = 2; i < myArray.Length; i++)
//     {
//         myArray[i] = myArray[i-1] + myArray[i-2];
//     }
//     return myArray;
// }

// Console.WriteLine("Input size");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] fibonacci = Fibonacci(size, a, b);
// ShowArray(fibonacci);













//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// void doubleNumber (int num)
// {
//     string Sum = string.Empty;
//     while (num > 0)
//     {
//         Sum = num % 2 + Sum;
//         num = num / 2;
//     }
//     Console.WriteLine(Sum);
// }

// Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());

// doubleNumber(num);
