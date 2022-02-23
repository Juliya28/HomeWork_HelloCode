// 49.	Показать двумерный массив размером m×n заполненный вещественными числами.

Console.Clear();

double[,] array = new double [6, 5];
Random rand = new Random();

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble()*100, 2);
        }
    }
}

void PrintArray(double[,] array)
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

