// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) 
// вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
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

int MaxOfRow(int[,] array, int i)
{
    int max = array[i-1, 0];
    for (var j = 0; j < array.GetLength(1); j++)
    {
        if (array[i-1, j] > max)
        {
            max = array[i-1, j];
        }
    }
    return max;
}

int MinOfCol(int[,] array, int j)
{
    int min = array[0, j-1];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, j-1] < min)
        {
            min = array[i, j-1];
        }
    }
    return min;
}


int[,] array = GenerateArray(2, 3, 0, 5);
PrintArray(array);
int max1 = MaxOfRow(array, 1);
int max2 = MaxOfRow(array, 2);
int sumOfMax = max1 + max2;
System.Console.WriteLine($"Сумма максимумов по строкам: {max1} + {max2} = {sumOfMax}");
int min1 = MinOfCol(array, 1);
int min2 = MinOfCol(array, 2);
int min3 = MinOfCol(array, 3);
int sumOfMin = min1 + min2 + min3;
System.Console.WriteLine($"Сумма минимумов по столбцам: {min1} + {min2} + {min3} = {sumOfMin}");
int result = sumOfMax - sumOfMin;
System.Console.WriteLine($"Сумма максимумов по строкам - Сумма минимумов по столбцам: {sumOfMax} - {sumOfMin} = {result}");