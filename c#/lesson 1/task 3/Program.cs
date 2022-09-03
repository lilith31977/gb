// напишите программу вычисления функции куба
// x = f(a)

int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}

int value = Prompt ("введите число >");
System.Console.WriteLine(value*value*value);