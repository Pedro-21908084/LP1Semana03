using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string input;
            perks[] NPCs;

            //get input and crated array of NPCs according
            Console.Write("Number of NPCs: ");
            input  = Console.ReadLine();
            NPCs = new perks [int.Parse(input)];

            foreach(perks npc in NPCs)
            {
                Console.WriteLine(npc.ToString());
            }
            //get perks of each NPC
            //print perks and special cases
        }
    }
}
