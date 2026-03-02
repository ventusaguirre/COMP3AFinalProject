using System;
using System.Collections.Generic;
using System.Text;

namespace COMP3AFinalProject
{
    public static class CharacterCreation
    {
        //character creation method
        public static Character CreateCharacter(int race, int clss, string gender, int age, int birthMonth)

        {
            while (true)
            {
                    //race
                    Console.Write("\nChoose character race - 1. orc, 2. goblin, 3. faerie, 4. dwarf (Enter 1-4): ");
                    int raceChoice = int.Parse(Console.ReadLine());

                    if (raceChoice >= 1 && raceChoice <= 4)
                    {
                        race = raceChoice;
                        Console.WriteLine($"Character race {race} confirmed.");
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    //class
                    Console.Write("\nChoose character class - 1. knight 2. monk 3. thief 4. mage (Enter 1-4): ");
                    int classChoice = int.Parse(Console.ReadLine());

                    if (classChoice >= 1 && classChoice <= 4)
                    {
                        clss = classChoice;
                        Console.WriteLine($"Character class {clss} confirmed.");
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    //gender
                    Console.Write("\nChoose character gender (M/F/NB): ");
                    string genderChoice = Console.ReadLine().ToUpper();

                    if (genderChoice == "M" || genderChoice == "F" || genderChoice == "NB")
                    {
                        gender = genderChoice;
                        Console.WriteLine($"Character gender {gender} confirmed.");
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    //age
                    Console.Write("\nEnter character age (10-999): ");
                    int ageChoice = int.Parse(Console.ReadLine());

                    if (ageChoice >= 10 && ageChoice <= 999)
                    {
                        age = ageChoice;
                        Console.WriteLine($"Character age {age} confirmed.");
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    //birth month
                    Console.Write("\nEnter character birth month (1-12): ");
                    int birthMonthChoice = int.Parse(Console.ReadLine());

                    if (birthMonthChoice >= 1 && birthMonthChoice <= 12)
                    {
                        birthMonth = birthMonthChoice;
                        Console.WriteLine($"Character birth month {birthMonth} confirmed");
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    return new Character(race, clss, gender, age, birthMonth);
               
            }
        }
    }
}
