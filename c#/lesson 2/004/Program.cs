// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int Number1 = new Random().Next(10, 10000);
System.Console.WriteLine(Number1);
int max = 0;
while (Number1 > 0)
{
int Temp = Number1 % 10;
    if (max < Temp)
        max = Temp;
    Number1 = Number1 / 10;
}
System.Console.WriteLine(max);





// int Prompt(string message)
// {
//     System.Console.Write("введите число >");      // вывод приглашение
//     string strValue;                              // объявление переменной для ввода строки
//     strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
//     int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
//     return value;
// }
// int a = Prompt("введите число >");