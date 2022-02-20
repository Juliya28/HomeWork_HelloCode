// 47.	Написать программу копирования массива.

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

int[] massiv = new int [11];

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = array[i];
    Console.Write(massiv[i] + " ");
}
Console.WriteLine();