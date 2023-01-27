using System;
using static System.Console;

Clear();

Write("Введите первый элемент: ");
int number1 = int.Parse(ReadLine());
Write("Введите последний элемент: ");
int number2 = int.Parse(ReadLine());
int sum = 0;

for (int i = number1; i <= number2; i++)
{
    sum += i;
}

WriteLine($"Сумма натуральных элементов в промежутке от {number1} до {number2} = {sum}");
