//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



//пузырковая


void Main()
{
    int[,] ourArray = new int[4, 6];
    FillArray(ourArray);
    PrintArray(ourArray);
    //Console.WriteLine($" 0 len = {ourArray.GetLength(0)}");
   // Console.WriteLine($" 1 len = {ourArray.GetLength(1)}");

    int[,] newArray = BubbleReorderRowsFromMaxToMin(ourArray);
    PrintArray(newArray);

}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }

    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();

    }


}

int[,] BubbleReorderRowsFromMaxToMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1); count++)
        {

            int temp = 0;


            for (int j = 1; j < arr.GetLength(1) - count; j++)
            {
                if (arr[i, j - 1] < arr[i, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }


            }


        }
    }
    return arr;

}

Main();