
// {
// int[,] matrix = new int [3,4];
// for (int i=0; i<matrix.GetLength(0);i++)
// {
//     for (int j=0; j<matrix.GetLength(0);j++)
//     {
//         System.Console.Write($"{matrix [i,j]}");
//     }
//     System.Console.WriteLine();
// }
// }




// int Factorial (int n)
// {
//     // 1!=1
//     // 0!=1
//     if (n==1) return 1;
//     else return n*Factorial(n-1);
// }
//         for (int i = 1; i<3; i++)
 
// {
// System.Console.WriteLine(Factorial(3));
// }


// для ф-и фиббоначи
int f(int n)
{
    if(n==1 || n==2) return 1;
    else return f(n-1) + f(n-2);
}
for(int i=1; i<10; i++)
{
    System.Console.WriteLine(f(i));
}