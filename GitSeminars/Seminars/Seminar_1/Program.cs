// Семинар № 1

// Задача № 0
// Сумма двух чисел и вывод двух чисел

// Console.WriteLine ("GB Задача №0");
// int numA = 5;
// int numB = Convert.ToInt32(Console.ReadLine());       // Команда запрашивает число у пользователя
// Console.WriteLine(numA + " " + numB);                 // Команда выводит рядом оба числа через пробел
// Console.WriteLine(numA + numB);                       // Команда выводит сумму двух чисел



// Задача № 1
// Ввести и возвести число в квадрат

// Console.WriteLine("Задача №1 возвести число в квадрат");
// Console.WriteLine("Input number");                   // Запрашиваем у пользователя число
// int num = Convert.ToInt32(Console.ReadLine());       // Записываем пользовательское число 
// int quad = num * num;                                // число * число
// Console.WriteLine($"Quad of {num} is {quad}");       // Вывод результата 



// Задача № 2
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. 

// Console.WriteLine("Задача №2 Проверка 2х чисел ");
// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

//  int quad = num2 * num2;
//  if (quad == num1)
//  {                                                                            // Если quad равно num1, то пишем текст
//     Console.WriteLine("First number is quad of second number");
//  }
//  else
//  {                                                                            // Иначе пишем текст
//     Console.WriteLine("First number is not quad of second number");
//  }



//  Задача № 3
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.WriteLine("Задача №3");
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = num * (-1);

// while(current <= num)
// {
//     Console.Write(current + " ");      // " " - добавление пробела в ответ
//     current++;
// }



// Задача № 4
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает послюднюю цифры этого числа.

// Console.WriteLine("Задача № 4");
// Console.WriteLine("Input tree-digit number");
// int num = Convert.ToInt32(Console.ReadLine ());

// int result = num % 10;                  // Остаток деления на 10

// Console.WriteLine($"Last digit of {num} is {result}");      // {} вставка переменных