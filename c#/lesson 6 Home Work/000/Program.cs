// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Сколько чисел вы собираетесь ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи число № {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Вы ввели {Comparison(array)} чисел больше нуля");
