// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}


int value = Prompt("введите число >");
for(int index = 2; index < value; index = index+2)
{
    System.Console.WriteLine($" {index},");
}