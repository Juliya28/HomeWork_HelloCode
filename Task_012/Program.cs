// 12.	Удалить вторую цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число: ");
string num = Console.ReadLine();
int number = int.Parse(num);

int a = number % 10;
int b = number / 10 % 10;
int c = number / 100 % 10;
int result = c * 10 + a;

Console.WriteLine(result);
