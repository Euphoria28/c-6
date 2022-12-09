// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Размер > ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandom(numbers);
System.Console.WriteLine("Массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"{numbers.Length}, {count} - четные");

void FillArrayRandom(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(10,100);

    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + "");
    }
    Console.Write("]");
    System.Console.WriteLine();
}