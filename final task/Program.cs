string[] array = new string[10] {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
string[] shortWord = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        shortWord[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array, shortWord);
PrintArray(shortWord);