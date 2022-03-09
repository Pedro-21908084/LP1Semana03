using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            float[,] array;
            string input;
            float meanPerLine = 0, addOfMeans = 0;

            //Read input
            Console.Write("Size (Ex: zXy): ");
            input = Console.ReadLine();
            string[] inSplt = input.Split("X");
            Console.WriteLine($"x={inSplt[0]} / y={inSplt[1]}");

            //Resize array according to input
            array = new float[int.Parse(inSplt[0]), int.Parse(inSplt[1])];

            //ask for values in each position of array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"array[{i}, {j}] = ");
                    input = Console.ReadLine();
                    array[i, j] = float.Parse(input);
                }
            }

            Console.WriteLine();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //calculates and print means of each line
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    meanPerLine += array[i, j];
                }
                meanPerLine /= array.GetLength(1);
                Console.WriteLine($"Mean of line {i+1} = {meanPerLine}");
                addOfMeans += meanPerLine;
                meanPerLine = 0;
            }
            //print the total of all the means
            Console.WriteLine($"Total of all means = {addOfMeans}");
        }
    }
}
