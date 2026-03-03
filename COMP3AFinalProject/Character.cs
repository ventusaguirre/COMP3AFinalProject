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
                    Console.Write("Invalid input, try again.");
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
                Console.Write("\nEnter character skin color (light, dark, tan, green, etc.): ");
                skinColor = Console.ReadLine();
                Console.WriteLine($"Character skin color {skinColor} confirmed.");
                break;
            }

            //height
            while (true)
            {
                Console.Write("\nEnter character height (tall, med, short): ");
                height = Console.ReadLine();
                Console.WriteLine($"Character height {height} confirmed.");
                break;
            }

            //body type
            while (true)
            {
                Console.Write("\nChoose character body type (Enter 1-5): ");
                int bodyTypeChoice = int.Parse(Console.ReadLine());

                if (bodyTypeChoice >= 1 && bodyTypeChoice <= 5)
                {
                    bodyType = bodyTypeChoice;
                    Console.WriteLine($"Character body type {bodyType} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //tattoos
            while (true)
            {
                Console.Write("\nTattoos? (T/F): ");
                string tattooChoice = Console.ReadLine().ToUpper();

                if (tattooChoice == "T")
                {
                    tattoos = true;
                    Console.WriteLine($"Character has tattoos - {tattoos}.");
                    break;
                }
                else if (tattooChoice == "F")
                {
                    tattoos = false;
                    Console.WriteLine($"Character has tattoos - {tattoos}.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //scars/birthmarks
            while (true)
            {
                Console.Write("\nScars/birthmarks? (T/F): ");
                string scarsBirthmarkChoice = Console.ReadLine().ToUpper();

                if (scarsBirthmarkChoice == "T")
                {
                    scarsBirthmarks = true;
                    Console.WriteLine($"Character has scars/birthmarks - {scarsBirthmarks}.");
                    break;
                }
                else if (scarsBirthmarkChoice == "F")
                {
                    scarsBirthmarks = false;
                    Console.WriteLine($"Character has scars/birthmarks - {scarsBirthmarks}.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //personality type
            while (true)
            {
                Console.Write("\nChoose character personality - 1. open, 2. conscientious, 3. extraverted, 4. agreeable, 5. neurotic (Enter 1-5): ");
                int personalityChoice = int.Parse(Console.ReadLine());

                if (personalityChoice >= 1 && personalityChoice <= 5)
                {
                    personality = personalityChoice;
                    Console.WriteLine($"Character personality type {personality} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //temperament
            while (true)
            {
                Console.Write("\nChoose character temperament - 1. sanguine, 2. choleric, 3. phlegmatic, 4. melancholic (Enter 1-4): ");
                int temperamentChoice = int.Parse(Console.ReadLine());

                if (temperamentChoice >= 1 && temperamentChoice <= 4)
                {
                    temperament = temperamentChoice;
                    Console.WriteLine($"Character temperament type {temperament} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //hobbies
            while (true)
            {
                Console.Write("\nEnter character hobbies (writing, painting, fishing, baking, etc.): ");
                hobbies = Console.ReadLine();
                Console.WriteLine($"Character hobbies {hobbies} confirmed.");
                break;
            }

            //criminal record
            while (true)
            {
                Console.Write("\nCriminal record? (T/F): ");
                string crimRecordChoice = Console.ReadLine().ToUpper();

                if (crimRecordChoice == "T")
                {
                    criminalRecord = true;
                    Console.WriteLine($"Character has criminal record - {criminalRecord}.");
                    break;
                }
                else if (crimRecordChoice == "F")
                {
                    criminalRecord = false;
                    Console.WriteLine($"Character has scars/birthmarks - {criminalRecord}.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //intelligence
            while (true)
            {
                Console.Write("\nEnter character intelligence (1-10): ");
                int intelligenceChoice = int.Parse(Console.ReadLine());

                if (intelligenceChoice >= 1 && intelligenceChoice <= 10)
                {
                    intelligence = intelligenceChoice;
                    Console.WriteLine($"Character intelligence level {intelligence} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //strength
            while (true)
            {
                Console.Write("\nEnter character strength (1-10): ");
                int strengthChoice = int.Parse(Console.ReadLine());

                if (strengthChoice >= 1 && strengthChoice <= 10)
                {
                    strength = strengthChoice;
                    Console.WriteLine($"Character strength level {strength} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            // magic
            while (true)
            {
                Console.Write("\nEnter character magic (1-10): ");
                int magicChoice = int.Parse(Console.ReadLine());

                if (magicChoice >= 1 && magicChoice <= 10)
                {
                    magic = magicChoice;
                    Console.WriteLine($"Character magic level {magic} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //dexterity
            while (true)
            {
                Console.Write("\nEnter character dexterity (1-10): ");
                int dexterityChoice = int.Parse(Console.ReadLine());

                if (dexterityChoice >= 1 && dexterityChoice <= 10)
                {
                    dexterity = dexterityChoice;
                    Console.WriteLine($"Character dexterity level {dexterity} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //speed
            while (true)
            {
                Console.Write("\nEnter character speed (1-10): ");
                int speedChoice = int.Parse(Console.ReadLine());

                if (speedChoice >= 1 && speedChoice <= 10)
                {
                    speed = speedChoice;
                    Console.WriteLine($"Character speed level {speed} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //luck
            while (true)
            {
                Console.Write("\nEnter character luck (1-10): ");
                int luckChoice = int.Parse(Console.ReadLine());

                if (luckChoice >= 1 && luckChoice <= 10)
                {
                    luck = luckChoice;
                    Console.WriteLine($"Character luck level {luck} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //charisma
            while (true)
            {
                Console.Write("\nEnter character charisma (1-10): ");
                int charismaChoice = int.Parse(Console.ReadLine());

                if (charismaChoice >= 1 && charismaChoice <= 10)
                {
                    charisma = charismaChoice;
                    Console.WriteLine($"Character charisma level {charisma} confirmed.");
                    break;
                }
                else
                {
                    Console.Write("Invalid input, try again.");
                }
            }

            //name
            while (true)
            {
                Console.Write("\nEnter character name: ");
                name = Console.ReadLine();
                Console.WriteLine($"\nNew character {name} has been created!");
                break;
            }

            return new Character(race, clss, gender, age, birthMonth, hairType, hairColor, eyeColor, 
                skinColor, height, bodyType, tattoos, scarsBirthmarks, personality, temperament, hobbies, 
                criminalRecord, intelligence, strength, magic, dexterity, speed, luck, charisma, name);
        }

        public void DisplayAllCharacters()
        {
            //foreach (Character in characterList)
            {
               // Console.WriteLine(characterList.Name);
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