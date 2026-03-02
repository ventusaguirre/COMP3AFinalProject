using System.ComponentModel;

namespace COMP3AFinalProject
{
    internal class Program
    {
        static void DisplayMenu()
        {
            Console.Write("Options:\n1. Create new character\n2. View all characters\n3. Search characters\n4. Display character statistics\n5. Exit\n\nEnter choice: ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*******Game Character Creation System*******\n");

            DisplayMenu();

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
                                Console.WriteLine("***New Character Creation***\n");
                                CreateNewCharacter();
                                break;

                            case 2:
                                Console.WriteLine("***Current Character List***\n");
                                
                                break;

                            case 3:
                                Console.WriteLine("***Search Characters***");
                                
                                break;

                            case 4:
                                Console.WriteLine("***Character Statistics***");

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
