// Написать программу копирования массива

int[] a = new int[7]; 
int[] b = new int[7]; 

for (int i = 0; i < 7; i++)
{
    a[i] = i + 20;
}
Console.WriteLine("Исходный массив:");

foreach (int j in a)
{
    int i = j - 20;
    Console.WriteLine("Элемент[{0}] = {1}", i, j);
}
Array.Copy(a, 0, b, 0, 7);

Console.WriteLine("Полученный в результате копирования массив:");

foreach (int res in b)
{
    Console.WriteLine(res);
}