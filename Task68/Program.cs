using System;
using static System.Console;

Clear();

Write("Введите первый элемент: ");
int number1 = int.Parse(ReadLine());
Write("Введите второй элемент: ");
int number2 = int.Parse(ReadLine());

WriteLine(AckermanFunction(number1, number2));


int AckermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}