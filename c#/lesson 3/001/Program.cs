// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
bool ValidateCoords(int inputNum)
void DeterminateQuarter(int inputQuarter)
{
    if (inputQuarter == 1)
    {
        System.Console.WriteLine("x > 0 && y > 0");
    }
    if (inputQuarter == 2)
    {
        System.Console.WriteLine("x < 0 && y > 0");
    }
    if (inputQuarter == 3)
    {
        System.Console.WriteLine("x < 0 && y < 0");
    }
    if (inputQuarter == 4)
    {
        System.Console.WriteLine("x > 0 && y < 0");
    }
}

int qNumber = Prompt("введите номер четверти >");

if (ValidateCoords(qnumber))
{
    DeterminateQuarter(qnumber);
}