// 5.	Найти максимальное из трех чисел.

int a1 = 36;
int a2 = 46;
int a3 = 66;
int max = a1;

if (max > a2)
{
   if (max > a3)
   {
       Console.WriteLine("max: " + a1);
   }
}
else if (a2 > a3)
{
    Console.WriteLine("max: " + a2);
} 
else if (a3 > a2)
{
    Console.WriteLine("max: " + a3);
}    
else
{
    Console.WriteLine("Числа равны");
}