// 73.	Написать программу показывающие первые N чисел, для которых каждое следующее
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

Console.Clear();
Console.WriteLine("Введите число 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество цифр: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("===================");

int Fibo(int z)
{
    if (z == 1) return n1;
    if (z == 2) return n2;
    return Fibo(z - 1) + Fibo(z - 2);
}

for (int i = 1; i < num + 1; i++)
{
    Console.WriteLine(Fibo(i));
}
