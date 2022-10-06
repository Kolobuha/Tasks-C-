// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] getRandomArray (int length, int reference, int endCountdown)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i ++)
    {
        resultArray [i] = new Random().Next(reference, endCountdown + 1);

    }
    return resultArray;
}
void printArray (int [] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray [i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine ("]");
}
int MaxNumbersArray (int [] incommingArray)
{
    int max = incommingArray[0];
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] > max)
        {
            max = incommingArray [i];
        }
    }
    return max;
}
int MinNumbersArray (int [] incommingArray)
{
    int min = incommingArray[0];
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] < min)
        {
            min = incommingArray [i];
        }
    }
    return min;
}
int [] currentArray = getRandomArray(12,-5,5);
printArray (currentArray);
int maxNumber = MaxNumbersArray (currentArray);
int minNumber = MinNumbersArray (currentArray);
Console.WriteLine($"разница между максимальным и минимальным элементами равна {maxNumber - minNumber}");