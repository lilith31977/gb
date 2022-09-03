// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет




int Prompt(string message)
{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value = Prompt("введите число > ");



if (1 == Value % 2)
{
    System.Console.WriteLine($" число = {Value} нечетное");
}
else
{
    System.Console.WriteLine($" число = {Value} четное");
}
