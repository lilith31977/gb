// Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7

int[] Create(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void DisplayArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write(" -> ");
}

int FindMax(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int FindSecondMax(int[] array, int max)
{
    int max2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max2 < array[i] && array[i] < max) max2 = array[i];
    }
    return max2;
}
int[] array = Create(8);
DisplayArray(array);
int max = FindMax(array);
int max2 = FindSecondMax(array, max);
System.Console.WriteLine($"Второе максимальное число = {max2}");