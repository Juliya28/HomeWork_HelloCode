// 58.	Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).

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

//bool num = false;
for (int i = 0; i < array.GetLength(0); i++)
 {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (m == n)
            {
                //num = true;
                massiv[i, j] = array[j, i];
                Console.Write(array[j, i] + "\t");
            }

        }
    Console.WriteLine();    
 }
if (m != n) Console.WriteLine("Введите одинаковое количество строк и столбцов.");