// Напишите программу, которая на вход принимает одно число (N) а на выходе показывает целые числа в промежутке от -N до N
// 4 - > -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 - > -2, -1, 0, 1, 2
int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}


int value = Prompt("введите число >");
for(int index = -value; index < value+1; index++ )
{
    System.Console.WriteLine($" {index},");
}