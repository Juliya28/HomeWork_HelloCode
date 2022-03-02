// 69.	Найти сумму элементов от M до N, N и M заданы.

Console.Clear();
Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int summ = 0;
int SummRec (int m, int n)
{
    if(m < n)
    {
       summ = summ + m;
         SummRec(m + 1, n);
       return summ + n;
    }
    else if(m > n)
    {
        summ = summ + n;
        SummRec(m, n + 1);
       return summ + m;
    }
    else
    {
       return summ;    
    }
}
Console.WriteLine($"Сумма элементов от {m} до {n} равна {SummRec(m,n)}");
Console.WriteLine();


