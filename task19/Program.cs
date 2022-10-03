// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int UserNumber = int.Parse(Console.ReadLine());
int rNumber = 0;
int modNumber = UserNumber;

if (UserNumber > 10000 && UserNumber < 99999)
{
    while (modNumber > 0)
    {
        rNumber = (rNumber * 10) + (modNumber % 10);
        modNumber = modNumber / 10;
    }

    if (rNumber == UserNumber)
    {
        Console.WriteLine($"число {UserNumber} является полиндромом");
    }
    else
    {
        Console.WriteLine($"число {UserNumber} не является полиндромом");
    }
}
else
{
    Console.WriteLine($"число {UserNumber} не является пятизначным");
}