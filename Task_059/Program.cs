// 59.	В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Введите одинаковое количество строк и столбцов!!!");
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

int summ = 0;
int result = 0;
int line = 1;
if (m == n)
{
for (int i = 0; i < m; i++)
{
    summ = 0;
    for (int j = 0; j < n; j++)
    {
        summ = summ + array[i, j];
    }
    Console.WriteLine($"Сумма строки {i + 1} = {summ}");
    Console.WriteLine();
    if (i == 0)
    {
        result = summ;
    }
    else
    {
        if (summ < result)
        {
            result = summ;
            line = i + 1;
        }
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {line}");
}
else
{
    Console.WriteLine("Введите одинаковое количество строк и столбцов!!!");
}
