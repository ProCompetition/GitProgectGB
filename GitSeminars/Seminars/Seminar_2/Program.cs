// Задача № 3
// Напишите программу, которая выводит случайное число из отрезкка [10, 99] и показывает наибольшую цифру числа.

// void MaxDecimal (int num)
// {
//    int ed = num % 10;
//    int dec = num / 10;
//    if(ed>dec)
//    {
//        Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//    }
//    else
//    {
//        Console.WriteLine($"Большая цифра числа {num} -> {dec}");
//    }
// }

// int randomnumber = new Random().Next(10, 100);

// MaxDecimal(randomnumber);



// Задача № 2 
// Напишите программу которая выводит случайное число трехзначное число и удаляет вторую цифру этого числа

// int DeleteDecimal (int num)
// {
//    int sot = num / 100;
//    int ed = num % 10;
//    return sot*10 + ed;
// }
// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);

// int result = DeleteDecimal(randomnumber);
// Console.WriteLine(result);

// Console.WriteLine(DeleteDecimal(randomnumber));



// Задача № 3
// Напишите программу принимающую два числа и выводить является ли второе число кратно первому числу или нет

// Console.WriteLine("Задача №3 Проверка чисел на кратность ");


// Console.WriteLine("Input first number");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input second number");
// double num2 = Convert.ToDouble(Console.ReadLine());

// void Decimal(double num1, double num2)

// {
//    if (num1%num2 ==0)
//    {
//        Console.WriteLine("Все хорошо");
//        }
//    else
//    {
//        Console.WriteLine($"остаток от деления {num1} / {num2} = {num1 % num2} ");
//    }
// }

// Decimal(num1, num2);



// Задача № 4 напишите программу которая на вход число и проверяет кратно ли число одновременно 7 и 23

// Console.WriteLine("Input random number");
// int num = Convert.ToInt32(Console.ReadLine());

// void Decimal723(int num)
// {
//    if (num % 7 == 0 && num % 23 == 0)    
//    {
//        Console.WriteLine("Все хорошо");
//    }
//    else
//    {
//        Console.WriteLine("Все плохо");
//    }
// }


// Decimal723 (num);
