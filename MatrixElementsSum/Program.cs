using System;

namespace MatrixElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter matrix row length: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter matrix column length: ");
            int column = int.Parse(Console.ReadLine());
            int[][] matrix = new int[row][];
            for (int i = 0; i < row; i++)
            {
                matrix[i] = new int[column];
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Enter an element: ");
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Here is your matrix!");
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(matrix[i][j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of acceptable values is {matrixElementsSum(matrix)}");
            Console.ReadLine();
        }
        static int matrixElementsSum(int[][] matrix)
        {
            int mainsum = 0;
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    mainsum += matrix[i][j];
                    if(matrix[i][j] == 0 && i != matrix.Length - 1)
                    {
                        for (int k = i + 1; k < matrix.Length; k++)
                        {
                            if(matrix[k][j] == 0)
                            {
                                break;
                            }
                            else
                            {
                                sum += matrix[k][j];
                            }
                        }
                    }
                }
            }
            return mainsum - sum;
        }
    }
}
