﻿Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit;

if( firstDigit < secondDigit)
{
    maxDigit = secondDigit;
}
Console.WriteLine(maxDigit);