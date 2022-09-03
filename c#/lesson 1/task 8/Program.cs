// вычислить числа фибоначи
int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";  
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
    return value;
    }
    throw  new Exception("данное значение невозможно преобразовать в целое число"); 
}
int value = Prompt ("введите число >");
if (value = 0)
{
    System.Console.WriteLine("число должно быть с нуля");
}
else
{
   System.Console.WriteLine($"номер числа в последовательности фибонначи {value} значение числа -> {Fibbonachi(value)}"); 
}
int Fibbonachi(int value)
{
    int Fibbonachi = 0;
    int tempVar1 = 0;
    int tempVar2 = 1;
    For (int i = 1; i <= value; i++)
{
    Fibbonachi = tempVar1 + tempVar1;
    tempVar1 = tempVar2;
    tempVar2 = Fibbonachi;
}
return Fibbonachi;
}