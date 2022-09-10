// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да



// Console.WriteLine("Задача 19");
// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");



int Prompt(string message)
{
    System.Console.Write(message);      // вывод приглашение
    string strValue;                              // объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0";         // вводим строку с консоли. Можно ввести только строку. Строчное значение. Если не заданно - считать как 0
    int value = int.Parse(strValue);              // преобразование строчного значения в целочисленное
    return value;
}
int value = Prompt("Введите пятизначное число >");
int i = 1; i++;
int Number(int value, int i)
{
    
    int result = value%(10*i)/Math.pow(10, i);
    return result;
}

if (value < 10000 || value > 99999)
{
    System.Console.WriteLine("это не пятизначное число");
}
else
{

// int count = value.ToString().Length;
// int[] nums = new int [count];
// for (int i = 0; i < count; i++)
// {
//     nums[i] = value % 10;
//        value /= 10;
// }


   int[] Array=new int[5];
    // Array[0] = Number1;
    // Array[1] = Number2;
    // Array[2] = Number3;
    // Array[3] = Number4;
    // Array[4] = Number5;
    
    Array[0] = value/10000;
    Array[1] = value%10000/1000;
    Array[2] = value%1000/100;
    Array[3] = value%100/10;
    Array[4] = value%10;
    
}

if (Array[0] == Array[4] && Array[1] == Array[3])
{
    System.Console.WriteLine("это число является полиндромом");
}
else
{
    System.Console.WriteLine("это число не является полиндромом");
}