// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int Number = new Random().Next(10, 1000);
int Number1 = Number / 100 * 10 + Number % 10;
System.Console.WriteLine(Number);
System.Console.WriteLine(Number1);