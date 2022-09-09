// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет
int Prompt(string message)
{
    System.Console.Write(message);                // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int number = Prompt("укажите номер дня недели >");
if (number < 1)
{
    System.Console.WriteLine("нет такого дня недели");
}
else
{
    if (number > 7)
    {
        System.Console.WriteLine("нет такого дня недели");
    }
    else
    {
        if (number > 5)
        {
            System.Console.WriteLine("это выходной день");
        }
        else
        {
            System.Console.WriteLine("это будний день");
        }
    }
}