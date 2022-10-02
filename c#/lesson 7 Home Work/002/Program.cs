// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] NewArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange + 1);
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

void PrintSearchValue(int[,] array, int[] position)
{
    if (position[0] <= array.GetLength(0) && position[1] <= array.GetLength(1))
    {
        System.Console.WriteLine($"{array[position[0]-1, position[1]-1]}");
    }
    else
    {
    System.Console.WriteLine($"Нет такого элемента");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Это значение нельзя преобразовать в число");
}

int[,] array = NewArray(3, 4, 0, 100);
PrintArray(array);
int[] position = new int[2];
for (int i = 0; i < position.Length; i++)
{
    position[i] = Prompt($"Введите позицию {i+1} искомого элемента (1-строка, 2-столбец) -> ");
}
System.Console.WriteLine($"{position[0]}, {position[1]}");
PrintSearchValue(array, position);