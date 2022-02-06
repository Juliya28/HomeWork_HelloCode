// 7.	Показать числа от -N до N.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int N = num1;

while (N <= num2)
{
    Console.Write(N);
    N++;
}

