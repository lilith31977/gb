// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22



int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("введите первое число > ");
int secondValue = Prompt("введите второе число > ");
int thirdValue = Prompt("введите третье число > ");


if (firstValue > secondValue)
{
    if (firstValue > thirdValue)
    {
        System.Console.WriteLine($" max = {firstValue}");
    }
    else
    {
        System.Console.WriteLine($" max = {thirdValue}");
    }

}
else
{
    if (secondValue > thirdValue)
    {
        System.Console.WriteLine($" max = {secondValue}");
    }
    else
    {
        System.Console.WriteLine($" max = {thirdValue}");
    }
}


