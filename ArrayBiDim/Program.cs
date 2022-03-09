using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            float [,] array;
            string input;

            //Read input
            Console.Write("Size (Ex: zXy): ");
            input = Console.ReadLine();
            string [] inputSplit= input.Split("X");
            Console.WriteLine($"x={inputSplit[0]} / y={inputSplit[1]}");
            //Resize array according to input
            //ask for values in each position of array
            //print means of each line
            //print the total of all the means
        }
    }
}
