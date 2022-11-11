// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
/*Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
void Main()
{
    Console.Clear();
    int[,] firstArray = new int[2, 2];
    FillArray(firstArray);

    int[,] secondArray = new int[2, 2];
    FillArray(secondArray);
Console.WriteLine("first arr ");
    PrintArray(firstArray);
    Console.WriteLine("*");
Console.WriteLine("sec arr ");
    PrintArray(secondArray);
    Console.WriteLine("=");

 MultiplyArrays(firstArray, secondArray);
   


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

    Console.WriteLine();
}

void MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)]; 

    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i <arr1.GetLength(0) ; i++)//1

        {
            for(int j = 0; j<arr2.GetLength(1); j++)//3
            {
                
                for (int k = 0; k < arr1.GetLength(1); k++)//1!
                {
                    
                
                resultArr[i,j] += (arr1[i,k]*arr2[k,j]);
                
                }
            }         
            
            
        }
          PrintArray(resultArr);

     

    }
    else
    {
        Console.WriteLine("Умножить две матрицы можно только в том случае, если число столбцов первой, равняется числу строк второй. \nИзмените размер матрицы и попробуйте снова");

    }
    
}

Main();
