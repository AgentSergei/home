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

int maxN = 0;

Console.WriteLine("Найти максимальное из трех чисел");

Console.Write("Первое число: ");
int firstN = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int secondN = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число: ");
int thirdN = Convert.ToInt32(Console.ReadLine());

if(firstN > maxN)
{
    maxN = firstN;
}
if(secondN > maxN)
{
    maxN = secondN;
}
if(thirdN > maxN)
{
    maxN = thirdN;
}

Console.WriteLine("max = " + maxN);


//Четность до N

Console.WriteLine("8 -> 2, 4, 6, 8");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int chetnoe = 2;

if(number > 1)
{
    while(chetnoe <= number)
    {
        Console.Write(chetnoe + " ");
        chetnoe = chetnoe + 2;
    }
}


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

// Оператор равенства == Оператор неравенства !=

Console.Write("\n Является ли число чётным (делится ли оно на два без остатка): ");
int numero = Convert.ToInt32(Console.ReadLine());

int chet = numero % 2;

if(chet == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("Нет");
}