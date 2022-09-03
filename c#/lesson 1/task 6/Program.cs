// Напишите программу которая на вход принимает значение а на выход показывает обратное значение
// 1 - > 1
// 2 - > 0,5
// 0,25 - > 4
double Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    double value = double.Parse(strValue);              
    return value;
}

double value = Prompt ("Введите число > ");
if(value==0)
{
System.Console.WriteLine("Нельзя делить на ноль");
}
else
{
double result = 1/value;  
System.Console.WriteLine($"{value} -> {result}");
}