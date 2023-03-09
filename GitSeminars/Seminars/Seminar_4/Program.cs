// Задача № 1 Напишите программу, которая принимает на вход число А и выдает сумму числе от 1 до А

// int FindSum(int a)
// {
//     int sum = 0;
//     for(int current = 1; current <=a; current++)
//     {
//         sum = sum + current;  // sum +=current;
//     }
//     return sum;
// }

// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));



//Задача 2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

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

//int[] myArray = CreateRandomArray(size, minValue, maxValue);

// ShowArray(CreateRandomArray(size, minValue, maxValue));


// Задача № 3 из комнаты № 4
//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// Console.WriteLine("Определение количества цифр в числе");
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int n = (int)Math.Log10(num) + 1;

// Console.WriteLine(n);




// Console.WriteLine("Input number");
// int x = Convert.ToInt32(Console.ReadLine());

// int NumberOfDigit (int x);
// {
//     int count = 0;
//     while (x>0)
//     {
//         x = x / 10;
//         count = count++;
//     }
//     return count;
// }


// Console.WriteLine($"{NumberOfDigit(x)}");









//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

// int FindMulti(int a)
// {
//     int multi = 1;
//     for(int current = 1; current <=a; current++)
//     {
//         multi = multi * current;  // sum +=current;
//     }
//     return multi;
// }

// Console.WriteLine("Определение фаториала числа X");
// Console.WriteLine("Input x");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{FindMulti(x)}");