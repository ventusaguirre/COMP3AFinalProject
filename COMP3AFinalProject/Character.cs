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
        public bool HasTattoos;
        public bool HasScars;
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
        public Character(string race, string type, string gender, int age, 
            int birthMonth, int hairType, string hairColor, string eyeColor,
            string skinColor, string height, int bodyType, bool tattoos, 
            bool scarsBirthmarks, int personality, int temperament, string hobbies, 
            bool criminalRecord, int intelligence, int strength, int magic, 
            int dexterity, int speed, int luck, int charisma, string name)
        {
            Race = race;
            Class = type;
            Gender = gender;
            Age = age;
            BirthMonth = birthMonth;
            HairType = hairType;
            HairColor = hairColor;
            EyeColor = eyeColor;
            SkinColor = skinColor;
            Height = height;
            BodyType = bodyType;
            HasTattoos = tattoos;
            HasScars = scarsBirthmarks;
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

        public void DisplayCharacterStats()
        {
            Console.WriteLine("\n***Character Stats***\n");
            Console.WriteLine($"Name: {Name}\nRace: {Race}\nClass: {Class}\nGender: {Gender}\nAge: {Age}");
            Console.WriteLine($"Birth Month: {BirthMonth}\nHair Type: {HairType}\nHair Color: {HairColor}\nEye Color: {EyeColor}\nSkin Color: {SkinColor}");
            Console.WriteLine($"Height: {Height}\nBody Type: {BodyType}\nTattoos: {HasTattoos}\nScars/Birthmarks: {HasScars}\nPersonality Type: {PersonalityType}");
            Console.WriteLine($"Temperament Type: {Temperament}\nHobbies: {Hobbies}\nCriminal Record: {CriminalRecord}\nIntelligence: {Intelligence}\nStrength: {Strength}");
            Console.WriteLine($"Magic: {Magic}\nDexterity: {Dexterity}\nSpeed: {Speed}\nLuck: {Luck}\nCharisma: {Charisma}");
        }

        public static Character CreateCharacter()

        {
            string race;
            string type;
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
                    Console.WriteLine("Invalid input, try again. ");
                }
            }

            //class
            while (true)
            {
                Console.Write("\nChoose character class - knight, monk, thief, mage : ");
                string typeChoice = Console.ReadLine().ToLower();

                if (typeChoice == "knight" || typeChoice == "monk" || typeChoice == "thief" || typeChoice == "mage")
                {
                    type = typeChoice;
                    Console.WriteLine($"Character class {type} confirmed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
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
                    Console.WriteLine("Invalid input, try again.");
                }
            }

            //age
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid integer, try again.");
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            //birth month
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            //hair type
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
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
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
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
                    Console.WriteLine("Invalid input, try again.");
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
                    Console.WriteLine("Invalid input, try again.");
                }
            }

            //personality type
            while (true)
            {
                try
                {
                    Console.Write("\nChoose character personality:\n1. open\n2. conscientious\n3. extraverted\n4. agreeable\n5. neurotic\n(Enter 1-5): ");
                    int personalityChoice = int.Parse(Console.ReadLine());

                    if (personalityChoice >= 1 && personalityChoice <= 5)
                    {
                        personality = personalityChoice;
                        Console.WriteLine($"Character personality type {personality} confirmed.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            //temperament
            while (true)
            {
                try
                {
                    Console.Write("\nChoose character temperament:\n1. sanguine\n2. choleric\n3. phlegmatic\n4. melancholic\n(Enter 1-4): ");
                    int temperamentChoice = int.Parse(Console.ReadLine());

                    if (temperamentChoice >= 1 && temperamentChoice <= 4)
                    {
                        temperament = temperamentChoice;
                        Console.WriteLine($"Character temperament type {temperament} confirmed.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            //hobbies
            while (true)
            {
                Console.WriteLine("\nEnter character hobbies (writing, painting, fishing, baking, etc.): ");
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
                    Console.WriteLine($"Character has criminal record - {criminalRecord}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }

            //intelligence
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                        Console.WriteLine("Invalid input.");
                }
            }

            //strength
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }

            // magic
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input");
                }
            }

            //dexterity
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }

            //speed
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }

            //luck
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
            }

            //charisma
            while (true)
            {
                try
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
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
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

            return new Character(race, type, gender, age, birthMonth, hairType, hairColor, eyeColor, 
                skinColor, height, bodyType, tattoos, scarsBirthmarks, personality, temperament, hobbies, 
                criminalRecord, intelligence, strength, magic, dexterity, speed, luck, charisma, name);
        }        
    }
}