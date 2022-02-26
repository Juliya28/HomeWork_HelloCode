// 53.	В двумерном массиве показать позиции числа, заданного пользователем или указать, 
// что такого элемента нет.

Console.Clear();
Console.Write("Введите число, которое даст количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число, которое даст количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

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
Console.WriteLine("===================");

bool position = true;
void SearchNumber(int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[i, j] == num)
            {
                position = false;
                Console.WriteLine($"Число {num} находится на позиции: {i}, {j}");
            }
        }
    }
    if (position) Console.WriteLine("В данном массиве введенное число не найдено.");
}
SearchNumber(num);
Console.WriteLine();
