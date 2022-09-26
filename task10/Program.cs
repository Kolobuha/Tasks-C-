//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число"); 
int number = Convert.ToInt32(Console.ReadLine());  

if (number > 999)
    {
    Console.WriteLine($"число {number} имеет более трех знаков");
    }

else if (number < 100)
    {
    Console.WriteLine($"число {number} имеет менее трех знаков");
    }
    
else
{
Console.WriteLine(number); 
int Two = (number / 10) % 10; 
Console.WriteLine($"вторая цифра числа {number} это {Two}");
}