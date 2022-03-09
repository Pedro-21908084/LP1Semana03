using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            string input, character;
            char charToOmit;

            //read input
            Console.Write("String: ");
            input = Console.ReadLine();
            Console.Write("Carácter: ");
            character = Console.ReadLine();
            while(character.Length > 1)
            {
                Console.WriteLine("Error: to many characters.");
                Console.Write("Carácter: ");
                character = Console.ReadLine();
            }
            charToOmit = char.Parse(character);

            //run string printing every character expect specified
            Console.Write("Será impresso: ");
            foreach(char c in input)
            {
                if(c != charToOmit)
                    Console.Write(c);
            }
            Console.WriteLine();
            
        }
    }
}
