// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
int evenNumbers (int [] incommingArray)
{
    int result = 0;
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] % 2 ==0)
        {
            result = result + 1;
        }
    }
    return result;
}

int [] currentArray = getRandomArray(10, 100, 999);
printArray (currentArray);
int QuantEvenNumber = evenNumbers (currentArray);
Console.WriteLine($"в массиве {QuantEvenNumber} четных чисел");

