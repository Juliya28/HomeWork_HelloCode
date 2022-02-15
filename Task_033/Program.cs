// 33.	Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива.

int [] array = new int [12];

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(-500, 501);
    }
}

FillArray (array);

void PrintArray (int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
    Console.WriteLine();
}

PrintArray (array);

int positive = 0;
int negative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) positive += array[i];
    else negative += array[i];
}
Console.WriteLine($"Сумма положительных чисел = {positive} и сумма отрицательных чисел = {negative}");