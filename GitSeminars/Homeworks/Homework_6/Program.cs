// // Задачи для самостоятельного решения
// нужно разобраться 

//     // Task 41
// Console.WriteLine("Input please Size of Array");// asking for size
//  int Array_size = Convert.ToInt32(Console.ReadLine());

//  int[] new_Array = new int[Array_size];// creating of array based on size

// void toFillingArray (int[] Any_array)// filling of array by random numbers, based on requested assumptions
// {
//     for (int i = 0; i < Any_array.Length; i++)
//     {
//         Console.WriteLine("Input please next member of Array");
//         Any_array[i] = Convert.ToInt32(Console.ReadLine());
//     };
// };

// void toPrintingArray (int[] Any_array)
// {
//     int index = 0;
//     while( index < Any_array.Length-1)
//     {
//         Console.Write($"{Any_array[index]}; ");
//         index++;
//     };
//     Console.Write($"{Any_array[index]}.");
// };

// int CountZero (int[] Any_array)
// {
//     int count = 0;
//     for (int i = 0; i < Any_array.Length; i ++)
//     {
//         if(Any_array[i] == 0) {count++;};
//     }
//     return count;   
// }

// toFillingArray(new_Array);
// toPrintingArray(new_Array);
// Console.WriteLine("");
// int countzero = CountZero(new_Array);
// Console.WriteLine($"{countzero} zero in array");

// Task 43
Console.WriteLine("Input please k1 of equation y = k1*x + b1");
 int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please b1 of equation y = k1*x + b1");
 int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please k2 of equation y = k2*x + b2");
 int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input please b2 of equation y = k2*x + b2");
 int b2 = Convert.ToInt32(Console.ReadLine());

void toFindXY (double k1, double b1, double k2, double b2)
{
double x = (b2-b1)/(k1-k2);
double y = k1*x +b1;
Console.WriteLine($"x = {x} and y = {y}");
}

toFindXY(k1,b1,k2,b2);
