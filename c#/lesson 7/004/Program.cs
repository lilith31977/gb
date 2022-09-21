// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// + *посчитать количество искомых элементов 
// + *перенести все искомые элементы в конец двумерного массива
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4], количество элементов 3.
// Введенный элемент 6, результат: такого элемента нет.

int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    Random rnd = new Random();
    var array = new int[rowLength, colLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
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

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}

int[] SearchNumber(int[,] array, int number, int numberEntry)
{
    int[] answer = new int[2];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                answer[0] = i;
                answer[1] = j;
                count++;
                if (numberEntry == count)
                {
                    return answer;
                }
            }
        }
    }
    return answer;
}

int CountElements(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count++;
            }
        }
    }
    return count;
}


bool IsFound(int[] array)
{
    return !(array[0] == 0 && array[1] == 0);
}

void SwapElements(int[,] array, int[] index, int[] coords)
{
    int tempItem = array[coords[0], coords[1]];
    array[coords[0], coords[1]] = array[index[0], index[1]];
    array[index[0], index[1]] = tempItem;
}

void SortArray(int[,] array, int number)
{
    int count = CountElements(array, number);
    int[] coords = new int[2];
    int[] lastCoords = new int[2] { array.GetLength(0) - 1, array.GetLength(1) - 1 };

    while (count > 0)
    {
        coords = SearchNumber(array, number, count);
        SwapElements(array, lastCoords, coords);
        lastCoords[1]--;
        if (lastCoords[1] < 0)
        {
            lastCoords[1] = array.GetLength(1) - 1;
            lastCoords[0]--;
        }
        count--;
    }
}


int[,] array = GenerateArray(3, 4, 0, 10);
PrintArray(array);
int number = Prompt("Введите искомое число > ");
int[] searchNumber = SearchNumber(array, number, 2);
if (!IsFound(searchNumber))
{
    System.Console.WriteLine($"Введенный элемент {number}, результат: такого элемента нет");
}
else
{
    System.Console.WriteLine($"Введенный элемент {number}, результат: {searchNumber[0]}, {searchNumber[1]}, количество элементов {CountElements(array, number)}");
    SortArray(array, number);
    PrintArray(array);
}
