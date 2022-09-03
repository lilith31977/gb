// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 2 - > вторник
// 3 - > среда

int Prompt(string message)
{
    System.Console.Write(message);                               
    string strValue = Console.ReadLine() ?? "0";         
    int value = int.Parse(strValue);              
    return value;
}

string [] days = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

int value = Prompt ("Введите день недели >");
if (value <0 || value>7)
{
    System.Console.WriteLine("нет такого дня недели");
} 
else
{
int daysValue = value - 1;
System.Console.WriteLine($"{value} -> {days[daysValue]}");  
}
