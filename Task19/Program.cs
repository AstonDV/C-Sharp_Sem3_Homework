// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите любое пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num1 = number / 10000;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;
if (number < 10000 || number > 99999)
Console.WriteLine("Введенное число не является пятизначным, попробуйте снова");
else
{
    if (num1 == num5 && num2 == num4)
    Console.WriteLine("Поздравляем, введенное вами число является палиндромом!!!");
    else
    Console.WriteLine("Введенное вами число не является палиндромом");
}

