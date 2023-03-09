// Задача №1 Напишите программу, которая принимает на вход точки (X и Y)

// int quater (double x, double y)
// {
//     if( x > 0 && y > 0) return 1;
//     if( x < 0 && y > 0) return 2;
//     if( x < 0 && y < 0) return 3;
//     if( x > 0 && y < 0) return 4;
//     return 0;
// };
// Console.WriteLine("Input x");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input y");
// double y = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"quater number {quater(x,y)}");







// Задача № 2 Напишите программу, которая принимает координаты двух точек и находит расстояние между ними в 2д пространстве

// double x1, x2, y1, y2;
// Console.WriteLine("Please input X coordinate of First point]");
// x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Please input Y coordinate of First point]");
// y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Please input Z coordinate of First point]");
// x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Please input X coordinate of Second point]");
// y2 = Convert.ToDouble(Console.ReadLine());

// void Distance (double x1, double x2, double y1, double y2)
// {
//     Console.WriteLine($"1-st point is {x1};{y1}");
//     Console.WriteLine($"1-st point is {x2};{y2}");
//     double result = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)),3);
//     Console.WriteLine($"Distance is {result}");
// };
// Distance(x1, x2, y1, y2);

    // Input x,y coordinate, output number of quater

// string quater (int q)
// {
//     if( q == 1) return "x > 0 and y > 0";
//     if( q == 2) return "x < 0 and y > 0";
//     if( q == 3) return "x < 0 and y < 0";
//     if( q == 4) return "x > 0 and y < 0";
//     return "there is no such quater";
// };
// Console.WriteLine("Input quater number");
// int q = Convert.ToInt16(Console.ReadLine());

// Console.WriteLine($"range of coordinate: {quater(q)}");

    // Input N and, qard 


void qard (int num)
{   
    int index = 1;
    while (index < num+1)
    {
        Console.WriteLine($"{index} - > {index*index};");
        index ++;
    };
}
Console.WriteLine("Please input number to see range of qard");
int y = Convert.ToInt32(Console.ReadLine());
qard(y);