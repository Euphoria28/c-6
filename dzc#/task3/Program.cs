// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int a;
int i;
int n;

int[] value = new int[100];

Random rand = new Random();
n = 11;
Console.WriteLine("Массив вещественных чисел > ");
for (i = 0; i < n; i++)
{
    value[i] = rand.Next(0, 50);
    Console.Write(value[i] + " ");
}

var min = value[0];
var max = value[0];

for (i = 0; i < n; i++)
{
    if (value[i] < min)
    {
        min = value[i];
    }
    else if (value[i] > max)
    {
        max = value[i];
    }
}
Console.WriteLine("\nМинимальный элемент массива : " + min);
Console.WriteLine("Максимальный элемент массива: " + max);
for (i = 0; i < n; i++)
{
    Console.Write(value[i] + " ");
}


