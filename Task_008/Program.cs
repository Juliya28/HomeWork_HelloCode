// 8.	Показать четные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int N = 1;
while (N <= num)
{
    if(N % 2 == 0)
    {
    Console.WriteLine(N);
    }
    N++;
}
