//Вывести первые N строк треугольника Паскаля. Сделать вывод
//в виде равнобедренного треугольника

//НА СТАДИИ РАЗРАБОТКИ

void Main()
{
    Console.WriteLine("Введите нечетное число строк треугольника Паскаля");
    int N = int.Parse(Console.ReadLine()!);

    CreatePaskalTriangle(N);


}


void CreatePaskalTriangle(int N)
{
    if (N % 2 != 0)
    {
        N = N + 1;
    }

    int[,] arr = new int[N, N*2];
    int a = 0;
    int b = 0;




    arr[0, N] = 1;// поставили первую единичку в центр

    for (int i = 1; i < N; i++)
    {
        for (int j = 0; j < N*2; j++)

        {


            if (j - 1 < 0 && j + 1 > N*2 - 1)
            {
                a = 0;
                b = 0;
                arr[i, j] = a + b;
            }
            if (j - 1 < 0 && j + 1 < N*2)
            {
                a = 0;
                arr[i, j] = a + arr[i - 1, j + 1];
            }
            if (j + 1 > N*2 - 1 && j - 1 >= 0)
            {
                b = 0;
                arr[i, j] = arr[i - 1, j - 1] + b;
            }
            if (j - 1 >= 0 && j + 1 <= N*2 - 1)
            {
                a = arr[i - 1, j - 1];
                b = arr[i - 1, j + 1];
                arr[i, j] = a + b;
            }



        }

    }

    PrintArray(arr);
}



void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
            { Console.Write($"   "); }
            else Console.Write($"  {arr[i, j]}");
        }
        Console.WriteLine();

    }

    Console.WriteLine();
}

Main();



