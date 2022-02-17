// 38.	Найти сумму чисел одномерного массива стоящих на нечетной позиции.

Console.Clear();
int [] array = new int [11];

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(1, 20);
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

int result = 0;
for (int i = 1; i < array.Length; i+=2)
{
    result += array[i];
}
Console.WriteLine($"Сумма чисел, стоящих на нечётной позиции равна:: {result}");
