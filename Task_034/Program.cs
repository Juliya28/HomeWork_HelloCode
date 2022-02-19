// 34.	Написать программу замену элементов массива на противоположные.


void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(-10, 10);
    }
}

void PrintArray (int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int[] array = new int [11];

FillArray (array);
PrintArray (array);
Console.WriteLine();

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) 
    {
        result = array[i] * -1;
    }
    else 
    {
        result = array[i] * -1;
    }
Console.Write(result + " ");
}
Console.WriteLine();
