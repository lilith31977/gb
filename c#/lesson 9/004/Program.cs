﻿// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool Check(int a)
{
    if (a % 2 == 1)
    {
        return false;
    }
    if (a == 2)
    {
        return true;
    }

    return Check(a / 2);
}
bool result = Check(28);
System.Console.WriteLine(result);