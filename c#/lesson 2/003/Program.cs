// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.WriteLine("введите число");
int a = int.Parse(System.Console.ReadLine()!);
bool remains = (a % 7 == 0 && a % 23 == 0);
if (remains)
{
    System.Console.WriteLine("кратное");
}
else
{
    System.Console.WriteLine("нет"); 
}