// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    for (int i = 0; i < array.Length; i+=2)
    {
        count = count + array[i];
    }
    return count;
}

int[] array = GenerateArray(5, -9, 9);
PrintArray(array);
System.Console.WriteLine($"Cумма элементов на нечетных пoзициях = {Count(array)}");