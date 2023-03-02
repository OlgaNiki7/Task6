//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] RandomArray(int size)
{
    return new int[size];
}
void PrintArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
int[] array = RandomArray(5);

void FillArray(int[] arr)
{
    int size = arr.Length;
    int index = 0;
    while (index < size)
    {
        arr[index] = new Random().Next(-10, 10);
        index++;
    }
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"количество чисел больше нуля равно {PositiveNumbers(array)}");


//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

