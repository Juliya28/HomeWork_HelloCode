// 46.	Написать программу масштабирования фигуры.

Console.Write("Введите через пробел координаты фигуры (Например: (2,1) (0,0) (2,3) (1,2)): ");
string[] values = Console.ReadLine().Split(" ");

Console.Write("Введите коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine());
for (int i = 0; i < values.Length; i++) Console.Write(values[i] + " ");
Console.WriteLine();
double[] StrToDoubleCoordinate = new double[values.Length * 2];
for (int i = 0, j = 0; i < values.Length; i++, j += 2)
{
    string[] temp = values[i].Split('(', ',', ')');
    StrToDoubleCoordinate[j] = Math.Round((double.Parse(temp[1])) * k , 2);
    StrToDoubleCoordinate[j + 1] = Math.Round((double.Parse(temp[2])) * k, 2);
}
Console.Write("Полученные координаты фигуры: ");
for (int i = 0, j = 0; i < values.Length; i++, j += 2) 
Console.Write($"({StrToDoubleCoordinate[j]};{StrToDoubleCoordinate[j + 1]}) ");

