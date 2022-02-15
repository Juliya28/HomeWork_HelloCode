// 35.	Определить, присутствует ли в заданном массиве, некоторое число.

Console.Clear();
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

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num1 = Array.IndexOf(array, num);
if (num1 == -1) Console.WriteLine($"Число {num} отсутствует в заданном массиве");
else Console.WriteLine($"Число {num} присутствует в заданном массиве c позицией {num1 +1}");

/* int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        Console.Write($"Число {array[i]} присутствует в заданном массиве");
    }
    result++;
}
 */