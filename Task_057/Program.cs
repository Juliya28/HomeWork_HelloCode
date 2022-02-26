// 57.	Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите число, которое даст количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int [m, n];
int [,] massiv = new int [m, n];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
Console.WriteLine("===================");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        int maxposition = array[j, i];
        for (int k = j; k < n; k++)
        {
            if (array[i, k] > maxposition)
            {
                maxposition = array[i, k];
                array[i,k] = array[i,j];
                array[i,j] = maxposition;
            }
        }
    }
}

for (int i = 0; i < m; i++)
{
    int minposition = array[i, 0];
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();