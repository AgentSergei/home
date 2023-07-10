/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int max = 0;
int min = 0;

Console.WriteLine("Найти максимальное из двух чисел");

Console.Write("Первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second)
{
    max = first;
    min = second;
}
else
{
    max = second;
    min = first;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

int max = 0;

Console.WriteLine("Найти максимальное из трех чисел");

Console.Write("Первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

if(first > max)
{
    max = first;
}
if(second > max)
{
    max = second;
}
if(third > max)
{
    max = third;
}

Console.WriteLine("max = " + max);

