// 56.	Написать программу, которая обменивает элементы первой строки и последней строки.

Console.Clear();
Console.Write("Введите число, которое даст количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int [m, n];
int[] massiv = new int [m];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Измененный массив: ");
int temp;
for (int j = 0; j < array.GetLength(1); j++)
{
    temp = array[0, j];
    array[0, j] = array[array.GetLength(0)-1, j];
    array[array.GetLength(0)-1, j] = temp;
}
Console.WriteLine();
PrintArray(array);
Console.WriteLine();