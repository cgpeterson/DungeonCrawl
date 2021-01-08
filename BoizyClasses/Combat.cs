using System;

namespace Classes
{
    public class Combat
    {
        int pspeed;
        int espeed;
        Potion lhpotion = new Potion("Light Healing Potion", 15, 5);
        Potion mhpotion = new Potion("Moderate Healing Potion", 30, 15);
        Potion shpotion = new Potion("Severe Healing Potion", 55, 25);
        Potion hepotion = new Potion("Healling Elixir Potion", 250, 100);
        string[] menu = new string[] { "Attack", "Use Item", "Run" };
        int selection = 0;
        string buffer;
        public void Fight(ref Player player, Enemy enemy)
        {
            pspeed = player.weapon.Speed();
            espeed = enemy.speed;
            Console.Clear();
            while (player.health > 0 && enemy.health > 0)
            {
                if (pspeed >= espeed)
                    while (pspeed >= espeed)
                    {
                        Console.Write(player.Hitpoints());
                        Console.WriteLine("\t".PadRight(enemy.Condition().Length, '-'));
                        Console.Write('\t');
                        enemy.Display();
                        Console.Write('\t');
                        Console.WriteLine(enemy.Condition());
                        Console.WriteLine("\t".PadRight(enemy.Condition().Length, '-'));
                        while (true)
                        {
                            buffer = string.Empty;
                            Console.Write("\n\tWhat would you like to do:\t");
                            for (int i = 0; i < menu.Length; i++)
                            {
                                Console.Write($" {(i + 1)})  {menu[i]} ");
                            }
                            Console.WriteLine("");
                            buffer = Console.ReadLine();

                            try
                            {
                                selection = Int32.Parse(buffer);
                                break;
                            }
                            catch
                            {
                                buffer = string.Empty;
                                selection = 0;
                            }
                        }
                        if (selection == 1)
                        {
                            Console.WriteLine($"\tYou strike {enemy.ename} with your {player.weapon.name} for {player.weapon.Attack()}");
                            Console.WriteLine("\n\t\t{Press any key to continue}");
                            Console.ReadKey();
                            enemy.health -= player.weapon.Attack();
                            if (enemy.health < 1)
                                break;
                            pspeed -= 10;
                            Console.Clear();
                        }
                        else if (selection == 2)
                        {
                            player.DisplayInventory();
                            string buffer = Console.ReadLine().ToLower();
                            if (buffer.Contains("light"))
                            {
                                player.Heal(lhpotion);
                            }
                            else if (buffer.Contains("moderate"))
                            {
                                player.Heal(mhpotion);
                            }
                            else if (buffer.Contains("severe"))
                            {
                                player.Heal(shpotion);
                            }
                            else if (buffer.Contains("elixer"))
                            {
                                player.Heal(hepotion);
                            }
                            else
                            {
                                Console.WriteLine("You can't do that during combat!");
                            }
                        }
                        else if (selection == 3)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                if (selection == 3 && pspeed > espeed)
                {
                    break;
                }

                while (espeed > pspeed)
                {
                    Console.WriteLine(player.Hitpoints());
                    Console.Write('\t');
                    enemy.Display();
                    Console.Write('\t');
                    Console.WriteLine(enemy.Condition());
                    Console.WriteLine($"\t{enemy.ename} hits you for {enemy.damage}");
                    player.health -= enemy.damage;
                    espeed -= 10;
                    Console.WriteLine("\n\t\t{Press any key to continue}");
                    Console.ReadKey();
                }
            }
            if (selection == 3)
            {
                Console.WriteLine("You successfully ran away");
            }
            else if (player.health < 1)
            {
                Console.WriteLine("You have died");
            }
            else
            {
                Console.WriteLine("\n\tCongratulations on your well earned victory");
                Console.WriteLine($"\n\tYou have earned {enemy.experience} experience and {enemy.coins} coins.");
                player.experience += enemy.experience;
                player.Level();
                player.coins += enemy.coins;
            }
        }

    }
}
