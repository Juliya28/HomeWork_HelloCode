// 55.	Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
Console.WriteLine();

double result = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = result + array[i, j];
    }
    Console.WriteLine($"Средняя арифметическая {j + 1} столбца = {result / m:F2}"); // :F2 - Помогает откинуть лишние цифры после запятой
}
Console.WriteLine();