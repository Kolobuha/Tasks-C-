// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] getRandomArray(int length, int reference, int endCountdown)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(reference, endCountdown + 1);
    }
    return resultArray;
}
void printArray(int[] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray[i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int getSumOfEvenCountNumbers(int[] incommingArray)
{
    int result = 0;
    for (int i = 1; i < incommingArray.Length; i = i + 2)
    {
       
       result = result + incommingArray[i];
    }
    return result;
}

int[] currentArray = getRandomArray(15, -99, 99);
printArray(currentArray);
int SumOfEvenCountNumbers = getSumOfEvenCountNumbers(currentArray);
Console.WriteLine($"сумма элементов на нечетной позиции равна {SumOfEvenCountNumbers}");