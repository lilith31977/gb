// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Невозможно преобразовать в число");
}

double[] FindDot(double b1, double b2, double k1, double k2)
{
    double[] coord = new double[2];
    coord[0] = (b2 - b1) / (k1 - k2);
    coord[1] = k1 * coord[0] + b1;
    return coord;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
}

double b1 = Prompt($"Введите b1 >");
double b2 = Prompt($"Введите b2 >");
double k1 = Prompt($"Введите k1 >");
double k2 = Prompt($"Введите k2 >");

double[] coord = FindDot(b1, b2, k1, k2);

PrintArray(coord);