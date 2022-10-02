// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Сколько чисел вы будете вводить?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void Numbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите число № {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Check(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

Numbers(m);

Console.WriteLine($"Здесь {Check(array)} положтельных чисел");
