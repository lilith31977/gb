// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
bool ValidateCoords(int x, int y)
{
    if (!(x == 0 || y == 0))
    {
        return true;
    }
    System.Console.WriteLine("точка лежит на одной из осей");
    return false;
}
void DeterminateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("первая четверть");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine("вторая четверть");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine("третья четверть");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine("четвертая четверть");
    }
}

int x = Prompt("введите x >");
int y = Prompt("введите y >");
if (ValidateCoords(x, y))
// if (x!=0 && y!=0)
// (!(x==0) && !(y==0))
{
    DeterminateQuarter(x, y);

}