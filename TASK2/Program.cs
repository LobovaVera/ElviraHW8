// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

//если две строки с одинаковым минимальным значением - не решила.

void Main()
{
    int[,] ourArray = new int[3, 3];
    FillArray(ourArray);
    PrintArray(ourArray);
    GetSummAndFindMin(ourArray);


}

void GetSummAndFindMin(int[,] arr)
{
    int minSumm = 0;
    int summ = 0;
    int theMinRow = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    { summ =0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summ += arr[i, j];


        }
        if (i == 0)
        {
            minSumm = summ;
        }
        else if (summ < minSumm)
        {
            minSumm = summ;
            theMinRow = i;

        }


    }
    Console.WriteLine($"Строка с минимальный значением = {theMinRow + 1}");

}


void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 5);
        }

    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]}");
        }
        Console.WriteLine();

    }


}
Main();
