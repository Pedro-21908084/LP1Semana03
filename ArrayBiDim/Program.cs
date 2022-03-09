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

            //Read input
            Console.Write("Size (Ex: zXy): ");
            input = Console.ReadLine();
            string[] inSplt = input.Split("X");
            Console.WriteLine($"x={inSplt[0]} / y={inSplt[1]}");

            //Resize array according to input
            array = new float[int.Parse(inSplt[0]), int.Parse(inSplt[1])];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }

            //ask for values in each position of array
            //print means of each line
            //print the total of all the means
        }
    }
}
