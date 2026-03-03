using System;
using System.Collections.Generic;
using System.Text;

namespace COMP3AFinalProject
{
    public static class CharacterCreation
    {
        //character creation method
        public static Character CreateCharacter()

        {
            string raceChoice;
            string classChoice;
            string genderChoice;
            int ageChoice;
            int birthMonthChoice;

            //race
            while (true)
            {
                Console.Write("\nChoose character race - orc, goblin, faerie, dwarf : ");
                raceChoice = Console.ReadLine().ToLower();

                if (raceChoice == "orc" || raceChoice == "goblin" || raceChoice == "faerie" || raceChoice == "dwarf")
                {
                    Console.WriteLine($"Character race {raceChoice} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again. ");
                }
            }

            //class
            while (true)
            {
                Console.Write("\nChoose character class - knight, monk, thief, mage : ");
                classChoice = Console.ReadLine().ToLower();

                if (classChoice == "knight" || classChoice == "monk" || classChoice == "thief" || classChoice == "mage")
                {
                    Console.WriteLine($"Character class {classChoice} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //gender
            while (true)
            {
                Console.Write("\nChoose character gender (M/F/NB): ");
                genderChoice = Console.ReadLine().ToUpper();

                if (genderChoice == "M" || genderChoice == "F" || genderChoice == "NB")
                {
                    Console.WriteLine($"Character gender {genderChoice} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //age
            while (true)
            {
                Console.Write("\nEnter character age (10-999): ");
                ageChoice = int.Parse(Console.ReadLine());

                if (ageChoice >= 10 && ageChoice <= 999)
                {
                    Console.WriteLine($"Character age {ageChoice} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //birth month
            while (true)
            {
                Console.Write("\nEnter character birth month (1-12): ");
                birthMonthChoice = int.Parse(Console.ReadLine());

                if (birthMonthChoice >= 1 && birthMonthChoice <= 12)
                {
                    Console.WriteLine($"Character birth month {birthMonthChoice} confirmed");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            return new Character(raceChoice, classChoice, genderChoice, ageChoice, birthMonthChoice);
        }
    }
}
