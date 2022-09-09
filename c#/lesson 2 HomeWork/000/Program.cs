// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Prompt(string message)
{
    System.Console.Write(message);                // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int number = Prompt("введите трехзначное число >");
if (number / 100 < 1)
{
    System.Console.WriteLine("это не трехзначное число");
}
else
{
    int number2 = number%100/10;
    System.Console.WriteLine(number2);
}
