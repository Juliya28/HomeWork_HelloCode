// 63.	Сформировать трехмерный массив не повторяющимися
// двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

Console.Clear();
int [,,] array = new int [3, 3, 3];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            Console.Write($"Индексы элемента: [{i} {j} {k}] = {array[i, j, k]} ");
            Console.WriteLine();
        }
         Console.WriteLine();   
    }
    Console.WriteLine();
}
