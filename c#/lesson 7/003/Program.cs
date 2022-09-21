// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GenerateArray(int length, int minRange, int maxRange)
{
    var array = new int[length, length];
    var random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minRange, maxRange + 1);

        }
    }
    return array;
}
int Summ(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = summ + array[i, i];

    }
    return summ;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] numbers = GenerateArray(4, 0, 10);
int summ = Summ(numbers);
PrintArray(numbers);
System.Console.WriteLine(summ);