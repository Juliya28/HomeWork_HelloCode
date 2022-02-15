// 32.	Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

void FillArray (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random(). Next(0, 2);
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

int [] array = new int [8];

FillArray (array);
PrintArray (array);