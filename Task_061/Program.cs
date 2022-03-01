// 61.	Найти произведение двух матриц.

Console.Clear();
Console.Write("Введите число, которое даст количество строк первой матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов первой матрицы: ");
int n = int.Parse(Console.ReadLine());
Console.Clear();
Console.Write("Введите число, которое даст количество строк второй матрицы: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов второй матрицы: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int [m, n];
int [,] massiv = new int [m1, n1];

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
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("===================");

int[,] matrix = new int[m, n];
if (n != m1)
{
    Console.WriteLine("Введите одинаковое количество строк второй матрицы и столбцов первой матрицы!");
    Console.WriteLine();
}
else
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            int sum = 0;
            for (int k = 0 ; k < n; k++)
            {
                sum += array[i, k] * massiv[k, j];
            }
            matrix[i, j] = sum;
        
        }
    }
    Console.WriteLine("Произведение двух матриц: ");
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
}

