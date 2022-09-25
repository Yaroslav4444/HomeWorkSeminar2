/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
вторую цифру этого числа.
*/

int getSecondDigitFromNumber(int number)
{
    int result = new int();
    result = number % 100;
    result /= 10;
    return result;
}

Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if( number > 99 & number < 1000 )
{
    int num2 = getSecondDigitFromNumber(number);
    Console.WriteLine(num2);
}
else if( number < -99 & number > -1000 )
{
    int num2 = getSecondDigitFromNumber(number);
    num2 *= -1;
    Console.WriteLine(num2);
}