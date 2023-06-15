// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// вещественные числа - числа у которых есть дробная часть
int size = 8;
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
 if (array[i] > max)
    {
 max = array[i];
    }
 else if (array[i] < min)
    {
 min = array[i];
    }
}
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}