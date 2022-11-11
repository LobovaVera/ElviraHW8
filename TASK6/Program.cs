﻿//Задача 59: Задайтедвумерный массив из целых чисел. Напишите
/*программу, которая удалит строку и столбец, на пересечении которых
расположен наименьший элемент массива.*/
//
//удаляем строку и столбец мин элемента
void Main()
{
    int[,] ourArray = new int[6, 6];
    FillArray(ourArray);
   
    PrintArray(ourArray);
    Console.WriteLine();

    int[,] resultArray = FindMinAndDeleteRowAndCol(ourArray);
    PrintArray(resultArray);

}

int[,] FindMinAndDeleteRowAndCol(int[,] arr)
{
    int min = arr[0, 0];
    int minI = 0;
    int minJ = 0;


    int[,] newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minI = i;
                minJ = j;
            }
        }

    }
    int k = 0;
    int l = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != minI && j != minJ)
            {
                newArray[l, k] = arr[i, j];
                k++;
            }
        }
        if (i != minI)
        {
            l++;
            k = 0;
        }
    }
    return newArray;
}

void FillArray(int[,] arr)
{
    int value = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i, j] = value;
           value++;
           //arr[i,j] =new Random().Next(1,50);

        }

    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write($"   0{arr[i, j]}");

            }
            else
            {
                Console.Write($"   {arr[i, j]}");
            }
        }
        Console.WriteLine();
    }

}



Main();


/*void Shuffle(int[,] arr)
{
    int temp;
    int k;
    int b;
    for (int i = 0; i < arr.Length(0); i++)
    {
        for (int j = 0; j < length; j++)
        {
            k = new Random().Next(1, 10);
            b = new Random().Next(1, 10); //перезаписывает на записанные позиции :(
            temp = array[i,j];
            array[i,j] = array[k,b];
            array[k,b] = temp;
        }
    }
}*/