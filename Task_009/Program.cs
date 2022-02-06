// 9.	Показать последнюю цифру трёхзначного числа.

Console.WriteLine("Введите трехзначное число: ");
string a1 = Console.ReadLine();
int b1 = int.Parse(a1);
int result = b1 % 10;
Console.WriteLine(result);

