// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
   System.Console.WriteLine();
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = GenerateArray(4, 100, 999);
PrintArray(array);
System.Console.WriteLine($"В массиве {Count(array)} четных чисел");