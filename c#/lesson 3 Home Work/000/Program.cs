// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да



int Prompt(string message)
{
    System.Console.Write(message);      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int value = Prompt("Введите пятизначное число >");
int i = 1; i++;
int Number(int value, int i)
{
    
    int result = value%(10*i)/pow(10, i);
    return result;
}

int a = value/10000;
if (a < 0 || a > 9)
{
    System.Console.WriteLine("это не пятизначное число");
}
else
{
   int[] array=new int[5];
    array0 = Number1;
    array1 = Number2;
    array2 = Number3;
    array3 = Number4;
    array4 = Number5;
    // array [0] = value/10000;
    // array [1] = value%10000/1000;
    // array [2] = value%1000/100;
    // array [3] = value%100/10;
    // array [4] = value%10;
    
}

if (array[0] == array[4] && array[1] == array[3])
{
    System.Console.WriteLine("это число является полиндромом");
}
else
{
    System.Console.WriteLine("это число не является полиндромом");
}