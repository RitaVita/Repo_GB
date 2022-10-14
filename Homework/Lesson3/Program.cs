/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int length = num.Length;

if (length == 5)

    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндром");
    }

else
{
    Console.WriteLine("Введено неправильное число!");
}
