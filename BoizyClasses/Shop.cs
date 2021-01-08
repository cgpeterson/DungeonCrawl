using System;
using System.Collections.Generic;

namespace Classes
{
    public class Shop
    {
        string[] menu = new string[] { "Buy", "Sell", "Look at", "Exit" };

        int coins = 50;
        Dictionary<Item, int> inventory = new Dictionary<Item, int> { };
        Weapon rapier;
        Weapon axe;
        Weapon club;
        Potion lhpotion;
        Potion mhpotion;
        Potion shpotion;
        Potion hepotion;
        public Shop(int level)
        {
            if (level < 5)
            {
                rapier = new Weapon("Iron Rapier", 10, Weapon.Type.Rapier, 7, 15);
                axe = new Weapon("Iron Axe", 10, Weapon.Type.Axe, 15, 5);
                club = new Weapon("Iron Banded Club", 10, Weapon.Type.Club, 10, 10);
                lhpotion = new Potion("Light Healing Potion", 15, 5);

                inventory[rapier] = 1;
                inventory[axe] = 1;
                inventory[club] = 1;
                inventory[lhpotion] = 3;
            }
            else if (level < 10)
            {
                rapier = new Weapon("Steel Rapier", 20, Weapon.Type.Rapier, 15, 15);
                axe = new Weapon("Steel Axe", 20, Weapon.Type.Axe, 25, 5);
                club = new Weapon("Steel Banded Club", 20, Weapon.Type.Club, 20, 10);
                lhpotion = new Potion("Light Healing Potion", 15, 5);
                mhpotion = new Potion("Moderate Healing Potion", 30, 15);

                inventory[rapier] = 1;
                inventory[axe] = 1;
                inventory[club] = 1;
                inventory[lhpotion] = 6;
                inventory[mhpotion] = 3;
            }
            else if (level < 15)
            {
                rapier = new Weapon("Silver Rapier", 10, Weapon.Type.Rapier, 15, 20);
                axe = new Weapon("Silver Axe", 10, Weapon.Type.Axe, 25, 10);
                club = new Weapon("Silver Banded Club", 10, Weapon.Type.Club, 20, 15);
                lhpotion = new Potion("Light Healing Potion", 15, 5);
                mhpotion = new Potion("Moderate Healing Potion", 30, 15);
                shpotion = new Potion("Severe Healing Potion", 55, 5);

                inventory[rapier] = 1;
                inventory[axe] = 1;
                inventory[club] = 1;
                inventory[lhpotion] = 9;
                inventory[mhpotion] = 6;
                inventory[shpotion] = 3;
            }
            else if (level < 20)
            {
                rapier = new Weapon("Mithril Rapier", 10, Weapon.Type.Rapier, 15, 20);
                axe = new Weapon("Mithril Axe", 10, Weapon.Type.Axe, 25, 10);
                club = new Weapon("Mithril Banded Club", 10, Weapon.Type.Club, 20, 15);
                lhpotion = new Potion("Light Healing Potion", 15, 5);
                mhpotion = new Potion("Moderate Healing Potion", 30, 15);
                shpotion = new Potion("Severe Healing Potion", 55, 5);

                inventory[rapier] = 1;
                inventory[axe] = 1;
                inventory[club] = 1;
                inventory[lhpotion] = 9;
                inventory[mhpotion] = 9;
                inventory[shpotion] = 6;
            }
            else if (level >= 20)
            {
                rapier = new Weapon("Adamantine Rapier", 10, Weapon.Type.Rapier, 15, 20);
                axe = new Weapon("Adamantine Axe", 10, Weapon.Type.Axe, 25, 10);
                club = new Weapon("Adamantine Banded Club", 10, Weapon.Type.Club, 20, 15);
                lhpotion = new Potion("Light Healing Potion", 15, 5);
                mhpotion = new Potion("Moderate Healing Potion", 30, 15);
                shpotion = new Potion("Severe Healing Potion", 55, 25);
                hepotion = new Potion("Healling Elixir Potion", 250, 100);

                inventory[rapier] = 1;
                inventory[axe] = 1;
                inventory[club] = 1;
                inventory[lhpotion] = 9;
                inventory[mhpotion] = 9;
                inventory[shpotion] = 9;
                inventory[hepotion] = 1;
            }
        }

        void Display()
        {
            Console.WriteLine("\tWelcome to my humble shop please browse at you leisure: \n");
            string placeholder = "Item";
            Console.WriteLine($"\t{placeholder.PadRight(20, ' ')}\t # \t\tCost");
            Console.WriteLine("\t-------------------------------------------------------");
            foreach (var item in inventory)
            {
                Console.WriteLine($"\t{item.Key.name.PadRight(20, ' ')}\t{item.Value}\t\t{item.Key.cost}");
            }
            Console.WriteLine("\t-------------------------------------------------------");

        }
        public void Use(ref Player player)
        {
            int selection = -1;
            player.health = player.healthmax;
            while (selection != menu.Length)
            {
                selection = -1;
                Console.WriteLine($"\n{player.name}'s Gold: {player.coins}");
                Console.WriteLine($"Store's Gold: {coins}\n");
                Display();
                Console.Write("\t");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.Write($"{(i + 1)} {menu[i]}   ");
                }
                Console.WriteLine("");
                while (true)
                {
                    Console.Write("\tSelection: ");
                    string buffer = Console.ReadLine();
                    try
                    {
                        selection = Int32.Parse(buffer);
                    }
                    catch
                    {
                        buffer = string.Empty;
                        selection = -1;
                    }
                    if (selection > 0 && selection <= menu.Length)
                    {
                        break;
                    }
                    Console.WriteLine("\n\tInvalid Selection");
                }

                if (selection == 1)
                {
                    Console.WriteLine("Which of my lovely wares is fitting of your impecable taste?");

                    string buffer = Console.ReadLine().ToLower();
                    if (buffer.Contains("rapier"))
                    {
                        if (player.coins >= rapier.cost)
                        {
                            Buy(rapier);
                            player.Buy(rapier);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("axe"))
                    {
                        if (player.coins >= axe.cost)
                        {
                            Buy(axe);
                            player.Buy(axe);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("club"))
                    {
                        if (player.coins >= club.cost)
                        {
                            Buy(club);
                            player.Buy(club);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("light"))
                    {
                        if (player.coins >= lhpotion.cost)
                        {
                            Buy(lhpotion);
                            player.Buy(lhpotion);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("moderate"))
                    {
                        if (player.coins >= mhpotion.cost)
                        {
                            Buy(mhpotion);
                            player.Buy(mhpotion);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("severe"))
                    {
                        if (player.coins >= shpotion.cost)
                        {
                            Buy(shpotion);
                            player.Buy(shpotion);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else if (buffer.Contains("elixir"))
                    {
                        if (player.coins >= hepotion.cost)
                        {
                            Buy(hepotion);
                            player.Buy(hepotion);
                            Console.Clear();
                            Console.WriteLine($"You will be happy with that {buffer}");
                        }
                        else
                            Console.WriteLine("Oh! it seems you don't have enough coin to pay for that.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection");
                    }
                }
                else if (selection == 2)
                {
                    player.DisplayInventory();
                    Console.WriteLine("Which item are you looking to part with?");
                    Console.Write("Selection: ");
                    string buffer = Console.ReadLine().ToLower();
                    if (buffer.Contains("rapier"))
                    {
                        if (coins >= rapier.cost)
                        {
                            player.Sell(rapier);
                            Sell(rapier);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("axe"))
                    {
                        if (coins >= axe.cost)
                        {
                            player.Sell(axe);
                            Sell(axe);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("club"))
                    {
                        if (coins >= club.cost)
                        {
                            player.Sell(club);
                            Sell(club);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("light"))
                    {
                        if (coins >= lhpotion.cost)
                        {
                            player.Sell(lhpotion);
                            Sell(lhpotion);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("moderate"))
                    {
                        if (coins >= mhpotion.cost)
                        {
                            player.Sell(mhpotion);
                            Sell(mhpotion);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("severe"))
                    {
                        if (coins >= shpotion.cost)
                        {
                            player.Sell(shpotion);
                            Sell(shpotion);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else if (buffer.Contains("elixir"))
                    {
                        if (coins >= hepotion.cost)
                        {
                            player.Sell(hepotion);
                            Sell(hepotion);
                            Console.Clear();
                            Console.WriteLine($"Thank you for that {buffer}");
                        }
                        else
                            Console.WriteLine("I am sorry, but I cannot afford that item.");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection");
                    }
                }
                else if (selection == 3)
                {
                    Console.WriteLine("Which of my lovely wares has caught your eye?");

                    string buffer = Console.ReadLine().ToLower();
                    if (buffer.Contains("rapier"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(rapier))
                        {
                            Console.WriteLine($"This {buffer} is a long pointed blade. It is the fastest weapon type but also has the weakest damage.");
                        }
                    }
                    else if (buffer.Contains("axe"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(axe))
                        {
                            Console.WriteLine($"This {buffer} is a heavy splitting weapon. It is the slowest weapon type but also has the highest damage.");
                        }
                    }
                    else if (buffer.Contains("club"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(club))
                        {
                            Console.WriteLine($"This {buffer} is a hefty blugeoning weapon. It is a well balance weapon with moderate speed and damage.");
                        }
                    }
                    else if (buffer.Contains("light"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(rapier))
                        {
                            Console.WriteLine($"This {buffer} is a potion that restores 10 health.");
                        }
                    }
                    else if (buffer.Contains("moderate"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(rapier))
                        {
                            Console.WriteLine($"This {buffer} is a potion that restores 25 health.");
                        }
                    }
                    else if (buffer.Contains("severe"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(rapier))
                        {
                            Console.WriteLine($"This {buffer} is a potion that restores 50 health.");
                        }
                    }
                    else if (buffer.Contains("elixir"))
                    {
                        Console.Clear();
                        if (inventory.ContainsKey(rapier))
                        {
                            Console.WriteLine($"This {buffer} is a potion that restores 200 health.");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection");
                    }
                }
                else if (selection == 4)
                {
                    Console.WriteLine($"So long for now {player.name}.");
                    Console.WriteLine("\n\n\n\t\t{Press any key to continue}");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public void Buy(Item item)
        {
            if (inventory.TryGetValue(item, out int value))
            {
                coins += item.cost;
                if (value > 1)
                {
                    inventory[item] -= 1;
                }
                else
                {
                    inventory.Remove(item);
                }
            }
            else
            {
                Console.WriteLine("\n\n\tNo Item Found");
            }
        }
        public void Sell(Item item)
        {
            coins -= item.cost;
            inventory[item] += 1;
        }
    }
}
