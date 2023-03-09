// Задача № 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine ("Задача на определение палиндрома, необходимо ввести число");
// Console.WriteLine ("Введите пятизначное число");
// int Num = Convert.ToInt32(Console.ReadLine());

// int fives = Num % 10;
// int first = Num / 10000;
// int second = (Num/1000) % 10;
// int four = ((Num%100) - fives)/10;

// if (first == fives && second == four)
// {
//     Console.WriteLine("Yes, it's palindrome");
// }
// else
// {
//     Console.WriteLine("Nope, next time");
// }

// Задача № 1 Выполнена 



// Задача № 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// необходимо добавить ya, yb к задаче с семинара

// double FindDistance (double xa, double ya, double xb, double yb, double za, double zb)
// {
//     return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
// }

// Console.WriteLine("Input coordinate x for first point:");
// double xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate x for second point:");
// double xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate y for first point:");
// double ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate y for second point:");
// double yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate z for first point:");
// double za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinate z for second point:");
// double zb = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,za,xb,yb,zb)}");

// Задача № 2 решена по примеру задачи с семинара с добавлением точки в третьем векторе измерения



// Задача № 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine ("Задача, необходимо написать программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
// Console.WriteLine ("Введите число - N");
// int Num = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] Num)
// {
//   int counter = 1;
//   int length = Num.Length;
//   while (counter <  length)
//   {
//     Num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll)
// {
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[Num+1];
// Cube(arry);
// PrintArry(arry);
