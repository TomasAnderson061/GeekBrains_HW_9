/*Задача 64: Написать рекурсивную функцию перевода из
 десятичной системы исчисления в двоичную.
*/

string ConvertDec2Bin(int dec, string res)
{
    if (dec < 2)
    {
        int t = dec%2;
        res = res+t.ToString();
        string res2 = "";
        for (int i = res.Length-1; i>=0; i--)
            res2 = res2 + res[i];
        return res2;
    }
    else
    {
        int t = dec%2;
        res = res + t.ToString();
        return ConvertDec2Bin(dec/2, res);
    }
}

Console.Write("Введите число: ");
int Dec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Десятичному числу {Dec} = {ConvertDec2Bin(Dec, "")}");

/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

double SumM2N(int m, int n)
{
    if (m == n)
        return m;
    else if (m < n)
        return m + SumM2N(m + 1, n);

    return 1.0;
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных числей от {M} до {N} =  {SumM2N(M, N)}");

