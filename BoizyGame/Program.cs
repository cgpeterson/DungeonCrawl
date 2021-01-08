using Classes;
using System;
using System.Linq;

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            string buffer;
            string greeting;
            if (DateTime.Now.Hour < 12)
                greeting = "Morning";
            else if (DateTime.Now.Hour < 5)
                greeting = "Afternoon";
            else
                greeting = "Evening";
            //Get Username
            Console.Write($"Good {greeting} adventurer! What is your name: ");
            string username = Console.ReadLine();
            Player user = new Classes.Player(username);
            Console.Clear();

            //Get Difficulty Level
            Console.WriteLine($"AH! Yes {user.name} glad to see you as always. Or is this our first meeting? . . .");
            Console.WriteLine($"\t. . . no matter. As usual I will give you 10 gold and you will embark on an epic quest.\n");
            Console.WriteLine($"What level of difficulty are you looking for this time?");
            int selection;
            string[] difficulties = new string[] { "Easy", "Normal", "Hard", "Nightmare" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{(i + 1)}\t{difficulties[i]}");
            }
            //Selection error catching
            while (true)
            {
                Console.Write("Selection: ");
                buffer = Console.ReadLine();
                try
                {
                    selection = Int32.Parse(buffer);
                }
                catch
                {
                    buffer = string.Empty;
                    selection = -1;
                }
                if (selection > 0 && selection < 5)
                {
                    selection--;
                    Console.WriteLine($"Ah, going with a(n) {difficulties[selection]} adventure. Good choice!");
                    break;
                }
                Console.WriteLine("\n\tInvalid Selection");
            }
            Console.Clear();

            Console.WriteLine($"Before you go {user.name}, make sure to get some gear.\n");
            bool onward = true;
            while (onward)
            {
                Shop introShop = new Shop(user.level);
                introShop.Use(ref user);

                //Combat Tutorial
                Console.WriteLine("\nWould you like to train in combat against the dummy first?");
                buffer = Console.ReadLine().ToLower();
                if (buffer.Contains('y'))
                {
                    Combat combat = new Combat();
                    TrainingDummy dummy = new TrainingDummy();
                    combat.Fight(ref user, dummy);
                }
                else
                {
                    Console.WriteLine("I get it. Eager to start.");
                }


                //game loop
                while (user.health >= 1)
                {
                    Difficulty difficulty = new Difficulty(0);
                    //Load Difficulty possibly add difficulty change later also to allow biome change
                    switch (difficulties[selection])
                    {
                        case ("Easy"):
                            {
                                difficulty = new Difficulty(0);
                                break;
                            }
                        case ("Normal"):
                            {
                                difficulty = new Difficulty(1);
                                break;
                            }
                        case ("Hard"):
                            {
                                difficulty = new Difficulty(2);
                                break;
                            }
                        case ("Nightmare"):
                            {
                                difficulty = new Difficulty(3);
                                break;
                            }
                        default:
                            break;
                    }

                    //Questing
                    difficulty.Display(ref user);
                    //Shop
                    if (user.health > 0)
                    {
                        Shop shop = new Shop(user.level);
                        shop.Use(ref user);
                    }
                }

                Console.WriteLine("You have died your quest has ended.");
                Console.Write("Retry?(y/n): ");
                if (Console.ReadLine() == "n")
                    onward = false;
                else
                {
                    user = new Player(username);
                }
            }
        }
    }
}
