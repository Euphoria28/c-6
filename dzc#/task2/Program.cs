// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

System.Console.WriteLine("Случайный массив: ");
int[] CreateArray(int length, int minRange, int maxRange)
{

    int[] numbers = new int[length];

    for (int i = 0; i < numbers.Length; i++)
    {
        
        numbers[i] = new Random().Next(minRange, maxRange);
        
        if (numbers[i] % 2 == 0)
        {
            
         numbers[i]--;
        }
        
    }
    return numbers;
}
int length = 10;
int minRange = 9;
int maxRange = 100;
int[] arr = CreateArray(length, minRange, maxRange);





