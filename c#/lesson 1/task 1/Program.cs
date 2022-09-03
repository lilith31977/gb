// Напишите программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго 
//а = 5 b = 25 -> да 
//а = 2 b = 10 -> нет
//а = 9 b = 3 -> нет
//а = 3 b = 9 -> да

int Prompt(string message)
{
    System.Console.Write(message);      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int firstValue = Prompt("введите первое число >");
int secondValue = Prompt("введите второе число >");
if (firstValue * firstValue == secondValue)
{
    System.Console.WriteLine("-> да");
} else
{
    System.Console.WriteLine("-> нет");
}
