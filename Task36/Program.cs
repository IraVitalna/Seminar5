// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArrayRandomNumbers(array);

int sum = 0;

for (int y = 0; y < array.Length; y+=2)
    sum = sum + array[y];

    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] array)

{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}