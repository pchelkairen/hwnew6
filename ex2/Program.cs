// Показать числа Фибоначчи

Console.WriteLine("Ввидите значениe Фибоначчи: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[] fibonacci = new int[n];

int a = 0;
int b = 1;

fibonacci[0] = a;
fibonacci[1] = b;

for (int i = 2; i < n; i++)
{
    int c = a + b;
    fibonacci[i] = c;

    a = b;
    b = c;
}

foreach (int fib in fibonacci)
{
    Console.WriteLine($"{fib}");
}
