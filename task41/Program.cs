// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел будем вводить?");
int CountOfUserNumbers = Convert.ToInt32(Console.ReadLine());

void printArrayOfUserNumbers(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

int[] getUserArray(int CountOfUserNumbers)
{
    int[] userArray = new int[CountOfUserNumbers];
    for (int i = 0; i < CountOfUserNumbers; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}

int getPoositivNum(int[] UserArray)
{
    int count =0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if(UserArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] TestArray = getUserArray(CountOfUserNumbers);
Console.WriteLine("Вы ввели следующие числа");
printArrayOfUserNumbers(TestArray);
int SumPositivNum = getPoositivNum(TestArray);
Console.WriteLine($"Среди введенных чисел {SumPositivNum} из них больше нуля");