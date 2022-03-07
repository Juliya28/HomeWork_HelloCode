// 76.	Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6
// Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰.


Console.Clear();
Console.Write("Введите N: ");
int num = Int32.Parse(Console.ReadLine());

int group = 0;
void SeveralGroup(int num)
{
    for (int i = 1; i <= num; i++)
    {
        if (i == Math.Pow(2, group))
        {
            Console.WriteLine();
            group++;
            Console.Write($"Группа {group}: ");
        }
            Console.Write($"{i} ");
    }
        Console.WriteLine();
        Console.WriteLine();
}
SeveralGroup(num);
