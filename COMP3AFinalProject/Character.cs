using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace COMP3AFinalProject
{
    public class Character
    {
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

        public Character( string race, string clss, string gender,int age, 
            int birthMonth, int hairType, string hairColor,  string eyeColor, 
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

        public void CreateNewCharacter(string race, string clss, string gender, int age,
            int birthMonth, int hairType, string hairColor, string eyeColor,
            string skinColor, string height, int bodyType, bool tattoos,
            bool scarsBirthmarks, int personality, int temperament, string hobbies,
            bool criminalRecord, int intelligence, int strength, int magic,
            int dexterity, int speed, int luck, int charisma, string name)
        {
            Console.Write("Choose character race (orc, goblin, elf, faerie, dwarf): ");

        }

        public void DisplayAllCharacters()
        {

        }

        public void SearchCharacters()
        {

        }

        public void DisplayCharacterStats()
        {

        }

        List<Character> characters = new List<Character>();
    }
}