// 39.	Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д..

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

int j = 0;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    j = array.Length -1 - i;
    Console.WriteLine($"{array[i]} x {array[j]}");
}
Console.WriteLine();