// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.WriteLine("Ввведите число M ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввведите число N ");
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return (start + "," +  PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(M,N));

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Ввведите число M");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввведите число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num, int twoNum)
// {
//     if(num==twoNum)return twoNum;
//     return (num+ SumNumbers(num+1,twoNum));
 
// }
// Console.WriteLine(SumNumbers(number,N));





// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Ввведите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите число N");
int N = Convert.ToInt32(Console.ReadLine());


int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
Console.WriteLine($"A({M}, {N}) = {AckermannFunction(M,N)}");