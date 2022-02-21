// 44.	Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Clear();

Console.WriteLine("Введите четыре числа через пробел для одной прямой k1 и b1, а для второй прямой k2 и b2: ");
string[] array = Console.ReadLine().Split(' ');
double[] arr = new double[4];

void FillArray(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i++) 
    {
        massiv[i] = double.Parse(array[i]);
    }
}
FillArray(arr);

double x = (arr[1] - arr[3]) / (arr[0] - arr[2]); // y - y = k1 * x + b1 - (k2 * x + b2)
double y = (arr[0] * x) + arr[1]; // y = k1 * x + b1

Console.WriteLine($"Точка пересечения прямых на координатах х = {x} и у = {y}");
Console.WriteLine();
