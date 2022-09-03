// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9


int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int firstValue = Prompt("введите первое число >");
int secondValue = Prompt("введите второе число >");

if (firstValue == secondValue)
{
    System.Console.WriteLine("эти числа равны");
}
else

{
    if (firstValue > secondValue)
    {
        System.Console.WriteLine($" max = {firstValue}, min = {secondValue}");
    }
    else
    {
        System.Console.WriteLine($" max = {secondValue}, min = {firstValue}");
    }
}


