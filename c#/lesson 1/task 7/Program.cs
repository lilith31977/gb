// вычислить факториал числа
int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}
int value = Prompt("Введите число > ");
int factorial = 1;
if (value < 0)
{
System.Console.WriteLine("число должно быть больше нуля");
}
else
{
for (int i = 1;i<= value; i++)
{
factorial = factorial*i;
}
System.Console.WriteLine($"факториал числа {value} равен - > {factorial}");
}


