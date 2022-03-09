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
            int indice = 1;

            //get input and crated array of NPCs according
            Console.Write("Number of NPCs: ");
            input = Console.ReadLine();
            NPCs = new perks[int.Parse(input)];

            //get perks of each NPC
            for (int i = 0; i < NPCs.Length; i++)
            {
                Console.WriteLine($"Perks of {indice}º NPC:");
                indice++;

                Console.WriteLine(perks.Stealth.ToString() + $"?(y/n) ");
                input = Console.ReadLine();
                if (input == "y")
                    NPCs[i] |= perks.Stealth;
                Console.WriteLine(perks.Combat.ToString() + $"?(y/n) ");
                input = Console.ReadLine();
                if (input == "y")
                    NPCs[i] |= perks.Combat;
                Console.WriteLine(perks.Lockpick.ToString() + $"?(y/n) ");
                input = Console.ReadLine();
                if (input == "y")
                    NPCs[i] |= perks.Lockpick;
                Console.WriteLine(perks.Luck.ToString() + $"?(y/n) ");
                input = Console.ReadLine();
                if (input == "y")
                    NPCs[i] |= perks.Luck;
            }

            //print perks and special cases
            indice = 1;
            foreach (perks npc in NPCs)
            {
                Console.Write($"NPC {indice}");
                if ((npc & perks.Luck) == perks.Luck &&
                    (npc & perks.Combat) == perks.Combat)
                    Console.WriteLine($" shall win all fights!");
                else
                {
                    if (npc == 0)
                        Console.WriteLine(" has nothing.");
                    else
                    {
                        Console.WriteLine(" has:");
                        if ((npc & perks.Stealth) == perks.Stealth)
                            Console.WriteLine(perks.Stealth.ToString());
                        if ((npc & perks.Combat) == perks.Combat)
                            Console.WriteLine(perks.Combat.ToString());
                        if ((npc & perks.Lockpick) == perks.Lockpick)
                            Console.WriteLine(perks.Lockpick.ToString());
                        if ((npc & perks.Luck) == perks.Luck)
                            Console.WriteLine(perks.Luck.ToString());
                    }

                }
                indice++;

            }
        }
    }
}
