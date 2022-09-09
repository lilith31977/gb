// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write("введите число >");      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int number1 = Prompt("введите первое число >");
int number2 = Prompt("введите второе число >");
int value = number2%number1;

if (value != 0)
{
       System.Console.WriteLine($"не кратно, остаток от деления {number2}, {number1}, {value}");
}
else
{
    System.Console.WriteLine($"{number2} кратно {number1}");
}