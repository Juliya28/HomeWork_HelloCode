// 54.	В матрице чисел найти сумму элементов главной диагонали.

Console.Clear();
Console.Write("Введите число, которое даст количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int [m, n];

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

int summ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    summ += array[i, i];
}

Console.WriteLine($"Сумма элементов: {summ}");
Console.WriteLine();
