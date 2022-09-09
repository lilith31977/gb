// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 
int Prompt(string message)
{
    System.Console.Write(message);      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
// }
// int number1 = Prompt("введите первое число >");
// int number2 = Prompt("введите второе число >");
// int number3 = Prompt("введите третье число >");
// int number4 = Prompt("введите четвертое число >");
// int number5 = Prompt("введите пятое число >");
// int sum = (number1+number2+number3+number4+number5);
// int average = sum/5;
// System.Console.WriteLine($"сумма {sum}, среднее {average}");
int[] numbers = new int [5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Prompt($"введите число {i + 1}:");
}
int sum = Sum(numbers);
double average;
// for (int i = 0; i < numbers.Length; i++)
// {
//     sum += numbers [i];
// }
average = sum / numbers.Length;
System.Console.WriteLine(sum);
System.Console.WriteLine(average);

int Sum (int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}