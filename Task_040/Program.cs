// 40.	В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(1, 100);
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

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (min >= array[i]) min = array[i];
    for (int j = 0; j < array.Length; j++)
    {
        if (max <= array[j]) max = array[j];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max} - {min} = {max - min}.");