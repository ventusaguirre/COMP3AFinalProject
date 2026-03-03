using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace COMP3AFinalProject
{
    public class Character
    {
        //fields
        public string Race;
        public string Class;
        public string Gender;
        public int Age;
        public int BirthMonth;
        public int HairType;
        public string HairColor;
        public string EyeColor;
        public string SkinColor;
        public string Height;
        public int BodyType;
        public bool Tattoos;
        public bool ScarsBirthmarks;
        public int PersonalityType;
        public int Temperament;
        public string Hobbies;
        public bool CriminalRecord;
        public int Intelligence;
        public int Strength;
        public int Magic;
        public int Dexterity;
        public int Speed;
        public int Luck;
        public int Charisma;
        public string Name;


        //constructor
        public Character(string race, string clss, string gender, int age, 
            int birthMonth, int hairType, string hairColor, string eyeColor,
            string skinColor, string height, int bodyType, bool tattoos, 
            bool scarsBirthmarks, int personality, int temperament, string hobbies, 
            bool criminalRecord, int intelligence, int strength, int magic, 
            int dexterity, int speed, int luck, int charisma, string name)
        {
            Race = race;
            Class = clss;
            Gender = gender;
            Age = age;
            BirthMonth = birthMonth;
            HairType = hairType;
            HairColor = hairColor;
            EyeColor = eyeColor;
            SkinColor = skinColor;
            Height = height;
            BodyType = bodyType;
            Tattoos = tattoos;
            ScarsBirthmarks = scarsBirthmarks;
            PersonalityType = personality;
            Temperament = temperament;
            Hobbies = hobbies;
            CriminalRecord = criminalRecord;
            Intelligence = intelligence;
            Strength = strength;
            Magic = magic;
            Dexterity = dexterity;
            Speed = speed;
            Luck = luck;
            Charisma = charisma;
            Name = name;

        }

        public static Character CreateCharacter()

        {
            string race;
            string clss;
            string gender;
            int age;
            int birthMonth;
            int hairType;
            string hairColor;
            string eyeColor;
            string skinColor;
            string height;
            int bodyType;
            bool tattoos;
            bool scarsBirthmarks;
            int personality;
            int temperament;
            string hobbies;
            bool criminalRecord;
            int intelligence;
            int strength;
            int magic;
            int dexterity;
            int speed;
            int luck;
            int charisma;
            string name;

            //race
            while (true)
            {
                Console.Write("\nChoose character race - orc, goblin, faerie, dwarf : ");
                string raceChoice = Console.ReadLine().ToLower();

                if (raceChoice == "orc" || raceChoice == "goblin" || raceChoice == "faerie" || raceChoice == "dwarf")
                {
                    race = raceChoice;
                    Console.WriteLine($"Character race {race} confirmed.");
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
                string classChoice = Console.ReadLine().ToLower();

                if (classChoice == "knight" || classChoice == "monk" || classChoice == "thief" || classChoice == "mage")
                {
                    clss = classChoice;
                    Console.WriteLine($"Character class {clss} confirmed.");
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
                string genderChoice = Console.ReadLine().ToUpper();

                if (genderChoice == "M" || genderChoice == "F" || genderChoice == "NB")
                {
                    gender = genderChoice;
                    Console.WriteLine($"Character gender {gender} confirmed.");
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
                int ageChoice = int.Parse(Console.ReadLine());

                if (ageChoice >= 10 && ageChoice <= 999)
                {
                    age = ageChoice;
                    Console.WriteLine($"Character age {age} confirmed.");
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
                int birthMonthChoice = int.Parse(Console.ReadLine());

                if (birthMonthChoice >= 1 && birthMonthChoice <= 12)
                {
                    birthMonth = birthMonthChoice;
                    Console.WriteLine($"Character birth month {birthMonth} confirmed");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //hair type
            while (true)
            {
                Console.Write("\nChoose character hair type (1-10): ");
                int hairTypeChoice = int.Parse(Console.ReadLine());

                if (hairTypeChoice >= 1 && hairTypeChoice <= 10)
                {
                    hairType = hairTypeChoice;
                    Console.WriteLine($"Character hair type {hairType} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input. Try again: ");
                }
            }

            //hair color
            while (true)
            {
                Console.Write("\nEnter character hair color (red, green, blue, black, etc.): ");
                hairColor = Console.ReadLine();
                Console.WriteLine($"Character hair color {hairColor} confirmed.");
                break;
            }

            //eye color
            while (true)
            {
                Console.Write("\nEnter character eye color (red, green, blue, black, etc.): ");
                eyeColor = Console.ReadLine();
                Console.WriteLine($"Character eye color {eyeColor} confirmed.");
                break;
            }

            //skin color
            while (true)
            {
                Console.Write("Enter character skin color (light, dark, tan, green, etc.): ");
                skinColor = Console.ReadLine();
                Console.WriteLine($"Character skin color {skinColor} confirmed.");
                break;
            }

            //height
            while (true)
            {
                Console.Write("Enter character height (tall, med, short");
                height = Console.ReadLine();
                Console.WriteLine($"Character height {height} confirmed.");
                break;
            }

            return new Character(race, clss, gender, age, birthMonth, hairType, hairColor, eyeColor, 
                skinColor, height, bodyType, tattoos, scarsBirthmarks, personality, temperament, hobbies, 
                criminalRecord, intelligence, strength, magic, dexterity, speed, luck, charisma, name);
        }

        public void DisplayAllCharacters()
        {
            //foreach (Character characters in Character)
            {
                //Console.WriteLine($"{Name}");
            }
        }

        public void SearchCharacters()
        {

        }

        public void DisplayCharacterStats()
        {
           //foreach (Character characters in Character)
            {

            }
        }

        
    }
}