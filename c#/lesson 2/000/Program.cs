// напишите программу которая принимает на ввод трехзначное число и на выходе покзывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2 
// 918 -> 8


int Prompt(string message)
{
    System.Console.Write("введите число >");      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int a = Prompt("введите число >");
if (a < 1000 && a > 99)
{
    int result = a % 10;
System.Console.WriteLine(result);
}
else System.Console.WriteLine("число не является трехзначным");