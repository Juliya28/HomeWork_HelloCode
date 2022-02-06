// 5.	Найти максимальное из трех чисел.

int a1 = 10;
int a2 = 12;
int a3 = 25;
if (a1 > a2)
{
   if (a1 > a3)
   {
       Console.WriteLine("max: " + a1);
   }
}
else if (a2 > a3)
{
    Console.WriteLine("max: " + a2);
}
else if (a2 < a3)
{
    Console.WriteLine("max: " + a3);
}
else
{
    Console.WriteLine("Числа равны");
}