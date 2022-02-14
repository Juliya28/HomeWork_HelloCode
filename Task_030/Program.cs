// 30.	Показать кубы чисел, заканчивающихся на четную цифру.

//Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
int num = new Random().Next(1, 100);
Console.WriteLine(num);

Console.WriteLine("Кубы чисел, заканчивающихся на четную цифру: ");

 for (int i = 1; i <= num; i++)
 {
     if ((i*i*i) % 2 == 0)
    Console.Write((i*i*i) + "\t");
 }
 Console.WriteLine();
