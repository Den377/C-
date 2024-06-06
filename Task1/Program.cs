// Задача 1. 
// Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// Пример:
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"



void PrintNaturalNumbers(int start, int end)
{
    if (start < end)
    {
        PrintNaturalNumbers2(start, end);
    }
    else
    {
        PrintNaturalNumbers1(start, end);
    }
}


void PrintNaturalNumbers1(int start, int end)
{
    if (start < end) return;
    Console.Write(start + " ");
    PrintNaturalNumbers1(start - 1, end);
}


void PrintNaturalNumbers2(int start, int end)
{
    if (start > end) return;
    Console.Write(start + " ");
    PrintNaturalNumbers2(start + 1, end);
}



Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {m} до {n}:");
PrintNaturalNumbers(m, n);