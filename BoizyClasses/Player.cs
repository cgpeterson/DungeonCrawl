using System;
using System.Collections.Generic;

namespace Classes
{
    public class Player
    {
        public string name;
        public int healthmax = 100;
        public int health;
        public int experience = 0;
        public int level = 1;
        public int coins = 10;
        public Dictionary<Item, int> inventory = new Dictionary<Item, int> { };
        Dictionary<string, int> potionbag = new Dictionary<string, int> { };
        public Weapon weapon;
        Weapon fists;

        public Player(string username)
        {
            name = username;
            fists = new Weapon("fists", 0, Weapon.Type.Club, (3 + (2 * level)), 25);
            weapon = fists;
            health = healthmax;
        }

        public void Level()
        {
            if (experience >= (10 * (level * 2)))
            {
                level++;
                healthmax += 10;
                health = healthmax;
                fists = new Weapon("fists", 0, Weapon.Type.Club, (5 + (2 * level)), 25);
                Console.WriteLine("Congratulations your efforts were worth while. Level Up! Level: " + level + Hitpoints());
            }
        }
        public void Damage(int value)
        {
            health -= value;
        }
        public void Heal(Potion potion)
        {
            if (potionbag.TryGetValue(potion.name, out int value))
            {
                if (health + potion.Heal() <= healthmax)
                {
                    health += potion.Heal();
                }
                else
                {
                    health = healthmax;
                }

                if (value > 1)
                {
                    potionbag[potion.name] -= 1;
                }
                else
                {
                    potionbag.Remove(potion.name);
                }
                Console.WriteLine($"You healed {potion.Heal()} hit points");
                Console.WriteLine("{Press any key to continue}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You don't have any of those.");
                Console.WriteLine("{Press any key to continue}");
                Console.ReadKey();
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"{name}'s Inventory: \n");
            string placeholder = "Item";
            Console.WriteLine($"\t{placeholder.PadRight(20, ' ')}\t # \t\tCost");
            Console.WriteLine("\t-------------------------------------------------------");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.Key.name}\t{item.Value}\t\t");
            }
            foreach (var item in potionbag)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}\t\t");
            }
            Console.WriteLine("\t-------------------------------------------------------");
        }

        public string Hitpoints()
        {
            return $"\tHealth: {health}/{healthmax}\n";
        }
        public void Buy(Item item)
        {
            coins -= item.cost;
            if (item is Weapon)
            {
                weapon = (Weapon)item;
                inventory.Add(weapon, 1);
            }
            else if (potionbag.ContainsKey(item.name))
            {
                potionbag[item.name] += 1;
            }
            else
                potionbag.Add(item.name, 1);
        }

        public void Sell(Item item)
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

                weapon = fists;

            }
            else if (potionbag.TryGetValue(item.name, out int value1))
            {
                if (value1 > 1)
                {
                    potionbag[item.name] -= 1;
                }
                else
                {
                    potionbag.Remove(item.name);
                }
            }
            else
            {
                Console.WriteLine("\n\n\tNo Item Found");
            }
        }
    }
}
