int[] RandomArray(int size)
{
    return new int[size];
}
void PrintArray(int[]array)
{
    int size = array.Length;
    int index = 0;
    while(index < size)
    {
        Console.Write (array[index] + " ");
        index++;
    }
}
int[]array = RandomArray(5);

void FillArray(int[]arr)
{
    int size = arr.Length;
    int index = 0;
    while(index < size)
    {
        arr[index] = new Random().Next(-10,10);
        index++;
    }
}

int PositiveNumbers(int[]array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] > 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"количество чисел больше нуля равно {PositiveNumbers(array)}");
