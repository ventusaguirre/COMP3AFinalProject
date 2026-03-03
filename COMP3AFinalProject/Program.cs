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
            Console.Write("\nOptions:\n1. Create new character\n2. View all characters\n3. Search characters\n4. Display character statistics\n5. Exit\n\nEnter choice: ");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game Character Creation System!");

            DisplayMenu();

            Character char1 = new Character("faerie", "mage", "NB", 27, 3, 7, "green", "brown", "brown", "short", 3, true, true, 4, 1, "playing guitar", true, 9, 6, 8, 7, 5, 7, 6, "Ventus");

            List<Character> characterList = new List<Character>();
            characterList.AddRange(new List<Character>() {char1});

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
                                Console.WriteLine("\n***New Character Creation***");
                                characterList.Add(Character.CreateCharacter()); 
                                break;

                            case 2:
                                Console.WriteLine("***Current Character List***\n");
                                
                                break;

                            case 3:
                                Console.WriteLine("***Search Characters***");
                                //SearchCharacters();
                                break;

                            case 4:
                                Console.WriteLine("***Character Statistics***");
                                //DisplayCharacterStats();
                                break;

                            case 5:
                                Console.WriteLine("\nThat was fun. Goodbye!");
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        Console.Write("Invalid integer. Enter choice: ");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid input. Enter choice: ");
                }
            }
        }     
        
    }
}
