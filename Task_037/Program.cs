// 37.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

Console.Clear();
int [] array = new int [123];

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

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) result++;

}
Console.WriteLine($"\n Количество чисел из отрезка [10, 99] равно:  {result} ");