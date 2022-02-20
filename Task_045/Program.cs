// 45.	Показать числа Фибоначчи.

double Fibonachi(int n)
{
    if (n < 3)
    {
        return 1;
    }
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
int num = 8;
Console.WriteLine(Fibonachi(num));

for (int i = 1; i < num; i++)
{
    Console.WriteLine(Fibonachi(i));
}