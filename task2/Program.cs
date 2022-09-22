/*
Задача 2: Программа из двух чисел выдает большее и меньшее значение.
*/
Console.Clear();
Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    Console.Write(userNumber1);
    Console.WriteLine(" больше");
    Console.Write(userNumber2);
    Console.WriteLine(" меньше");
}
else
{
    Console.Write(userNumber2);
    Console.WriteLine(" большее");
    Console.Write(userNumber1);
    Console.WriteLine(" меньшее");
}
