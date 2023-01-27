using System;
using static System.Console;

Clear();

Write("Введите первый элемент: ");
int number1 = int.Parse(ReadLine());
Write("Введите последний элемент: ");
int number2 = int.Parse(ReadLine());

for(int i = number1; i <= number2; i++)
{
    Write($"{i}, ");
}