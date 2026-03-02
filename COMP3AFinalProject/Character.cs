using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace COMP3AFinalProject
{
    public class Character
    {
        //fields
        public int Race { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int BirthMonth { get; set; }
        

        //constructor
        public Character(int race, int clss, string gender, int age, int birthMonth)
        {
            Race = race;
            Class = clss;
            Gender = gender;
            Age = age;
            BirthMonth = birthMonth;
        }

        public void DisplayAllCharacters()
        {
            //foreach (Character characters in Character)
            {
                Console.Write("");
            }
        }

        public void SearchCharacters()
        {

        }

        public void DisplayCharacterStats()
        {
            Console.Write("Which character's stats would you like to view?");
        }

        
    }
}