using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace COMP3AFinalProject
{
    internal class Program
    {
        static void DisplayMenu()
        {
            Console.Write("\nOptions:\n1. Create new character\n2. View all characters\n3. Display character stats\n4. Calculate totals/averages\n5. Exit\n\nEnter choice: ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game Character Creation System!");

            DisplayMenu();

            Character char1 = new Character("faerie", "mage", "NB", 27, 3, 7, "green", "brown", "brown", "short", 3, true, true, 4, 1, "playing guitar", true, 7, 6, 10, 8, 5, 9, 7, "Ventus");

            List<Character> party = new List<Character>();
            party.AddRange(new List<Character>() {char1});

            while (true)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice >= 1 && choice <= 5)
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\n\n***New Character Creation***");
                                party.Add(Character.CreateCharacter()); 
                                break;

                            case 2:
                                Console.WriteLine("\n\n***Current Character List***\n");
                                DisplayAllCharacters(party);
                                break;

                            case 3:
                                Console.WriteLine("\n\n***Display Character Stats***");
                                SearchCharacters(party);
                                break;

                            case 4:
                                Console.Write("\n\n***Calculate Totals/Averages***\n\nWhat would you like to calculate?\n1. Average strength\n2. Magic points total\n\nEnter choice: ");
                                try
                                {
                                    int choice2 = int.Parse(Console.ReadLine());

                                    switch (choice2)
                                    {
                                        case 1:
                                            CalculateAverageStrength(party);
                                            break;

                                        case 2:
                                            TotalMagicPoints(party);
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.Write("Invalid input.");
                                }
                                break;

                            case 5:
                                Console.WriteLine("\nThat was fun. Goodbye!");
                                Environment.Exit(0);
                                break;
                        }
                        
                        DisplayMenu();
                    }
                    else
                    {
                        Console.Write("\nInvalid integer. Enter choice: ");
                    }     
                }
                catch (FormatException)
                {
                    Console.Write("\nInvalid input. Enter choice: ");
                }
            }
        }
        static void DisplayAllCharacters(List<Character> party)
        {
            foreach (Character character in party)
            {
                Console.WriteLine(character.Name);
            }
        }

        static void SearchCharacters(List<Character> party)
        {
            Console.Write("\nEnter a character name to search: ");
            
            string searchName = Console.ReadLine().ToLower();

            foreach (Character character in party)
            {
                if (character.Name.ToLower() == searchName)
                {
                    Console.WriteLine($"\nCharacter {character.Name} found!");
                    character.DisplayCharacterStats();
                    return;
                }
            }

            Console.WriteLine("Character not found.");
        }

        static void CalculateAverageStrength(List<Character> party)
        {
            double totalStrength = 0;

            foreach (Character character in party)
            {
                totalStrength = totalStrength + character.Strength;
            }

            double averageStrength = totalStrength / party.Count;  

            Console.WriteLine($"\nParty's average strength: {averageStrength}");
        }

        static void TotalMagicPoints(List<Character> party)
        {
            int totalMagicPoints = 0;
            
            foreach (Character character in party)
            {
                totalMagicPoints = totalMagicPoints + character.Magic;
            }

            Console.WriteLine($"\nParty's total magic: {totalMagicPoints}");
        }
    }
}
