// Задача со звездочкой: Заполнить массив четной длины таким образом, 
// чтобы значение элемента массива повторялось ровно 2 раза.
// 1,1,2,3,3,2,4,5,4,5
// или
// 1,1,2,2,4,4,5,5
// или
// 1,2,3,3,2,1


int[] array = new int[32];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(); 

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
