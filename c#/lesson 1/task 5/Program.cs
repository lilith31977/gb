// Напишите программу вычисляющую модуль числа
// 2 - > 2
// -3 - > 3
// -7 - > 7
int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}
int value = Prompt ("введите число -> ");
int result;
if (value < 0)
{
result = - value;
}
else
{
result = value;
}
System.Console.WriteLine($"{value} -> {result}");