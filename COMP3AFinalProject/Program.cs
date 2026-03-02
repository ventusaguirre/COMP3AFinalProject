namespace COMP3AFinalProject
{
    internal class Program
    {
        static void DisplayMenu()
        {
            Console.Write("Options:\n1. Create new character\n2. View all characters\n3. Search characters\n4. Display character summary statistics\n5. Exit\n\nEnter choice: ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***Game Character Creation System***\n");

            DisplayMenu();

            while (true)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice >= 1 && choice <= 3)
                    {
                        switch (choice)
                        {
                            case 1:

                                break;

                            case 2:

                                break;

                            case 3:

                                break;

                            case 4:

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
