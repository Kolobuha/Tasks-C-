// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine ("введите цифру, обозначающую день недели");  
int number = Convert.ToInt32(Console.ReadLine()); 

if (number < 6 && number > 0)
{ 
    Console.WriteLine($"цифра {number} обозначает рабочий день недели"); 
} 
else if (number > 5 && number < 8)
{ 
        Console.WriteLine($"цифра {number} обозначает выходной день"); 
}
else
{
    Console.WriteLine($"цифра {number}? брат, с какой ты планеты??? на нашей неделя короче ;-("); 
}