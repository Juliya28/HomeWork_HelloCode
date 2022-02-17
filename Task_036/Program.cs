// 36.	Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел.

Console.Clear();
int [] array = new int [15];

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(100, 501);
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

int even = 0;
int odd = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) even++;
    else odd++;
}
Console.WriteLine($"Количество нечетных чисел: {odd}");
Console.WriteLine($"Количество четных чисел: {even}");