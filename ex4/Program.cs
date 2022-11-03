// Написать программу масштабирования фигуры для заданных kоординат

int[] a = { 0, 0 };
int[] b = { 2, 0 };
int[] c = { 2, 2 };
int[] d = { 0, 2 };

Console.WriteLine("Введите k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Координаты масштабированной фигуры: ");

foreach (int element in a)
{
    int a1 = element * k;
    Console.Write($"{a1} ");
}
Console.WriteLine();
foreach (int element in b)
{
    int b1 = element * k;
    Console.Write($"{b1} ");
}
Console.WriteLine();
foreach (int element in c)
{
    int c1 = element * k;
    Console.Write($"{c1} ");
}
Console.WriteLine();
foreach (int element in d)
{
    int d1 = element * k;
    Console.Write($"{d1} ");
}