// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine ("введите число");  
int Number = Convert.ToInt32(Console.ReadLine()); 
int Number3 =-1;

while (Number>99)
{
    Number3=Number%10;
    Number=Number/10;
}
if (Number3>=0)
    {
        Console.WriteLine($"третья цифра {Number3}");
    }
else
{
    Console.WriteLine($"число {Number} не имеет третьего знака");
}