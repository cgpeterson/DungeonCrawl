using System;
using System.Collections.Generic;

namespace Classes
{
    public class Difficulty
    {
        public int rooms;
        int difficulty;
        Combat combat = new Combat();
        enum RoomType
        {
            Forest,
            Desert,
            Cave,
            Dungeon
        }
        RoomType biome;
        public Dictionary<Room, int> roomselection;

        public Difficulty(int selection)
        {
            Random rand = new Random();
            difficulty = selection;
            rooms = 2 * (2 * selection);
            if (rooms < 1)
            {
                rooms = 3;
            }
            biome = (RoomType)(rand.Next() % (difficulty + 1));
        }

        public void Display(ref Player player)
        {
            for (int i = 0; i < rooms; i++)
            {
                Random rand = new Random();
                int enemyrand = 0;
                if ((player.level + difficulty) != 1)
                {
                    enemyrand = rand.Next() % (int)((player.level + difficulty) / 2);
                }
                switch (biome)
                {
                    case RoomType.Forest:
                        Console.WriteLine($"You are now entering a {biome.ToString()}");
                        Forest forest = new Forest(difficulty);
                        Console.WriteLine("\n");
                        Console.WriteLine(forest.description);
                        Console.WriteLine($"\n\t------------------------------------------------------------------------------");
                        
                        switch (enemyrand)
                        {
                            case 0:
                                Console.WriteLine($"\n\tA goblin crawls out of the bushes");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Goblin goblin = new Goblin(player.level, difficulty);
                                combat.Fight(ref player, goblin);
                                break;
                            case 1:
                                Console.WriteLine($"\n\tAn orc stands ready to fight");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Orc orc = new Orc(player.level, difficulty);
                                combat.Fight(ref player, orc);
                                break;
                            case 2:
                                Console.WriteLine($"\n\tAn ogre looms over you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Ogre ogre = new Ogre(player.level, difficulty);
                                combat.Fight(ref player, ogre);
                                break;
                            case 3:
                                Console.WriteLine($"\n\tA dragon swoops in smashing to the ground in front of you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Dragon dragon = new Dragon(player.level, difficulty);
                                combat.Fight(ref player, dragon);
                                break;
                            case 4:
                                Console.WriteLine($"\n\tA wizard materializes in front of you in a pillar of fire");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                EvilWizard wizard = new EvilWizard(player.level, difficulty);
                                combat.Fight(ref player, wizard);
                                break;
                            default:
                                Boss boss = new Boss(player.level, difficulty);
                                Console.WriteLine($"\n\t{boss.ename} narrowly misses you as you enter the area. {boss.ename} says,'Finally, {player.name}. I was beginning to think you weren't coming'.");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                combat.Fight(ref player, boss);
                                break;
                        }
                        Console.WriteLine(forest.description);
                        Console.WriteLine($"\n\t------------------------------------------------------------------------------");
                        //List<string> commands = forest.commands();
                        Console.WriteLine("Onward!\n\t{Press any key to continue}");
                        Console.ReadKey();
                        break;
                    case RoomType.Desert:
                        Console.WriteLine($"You are now entering a {biome.ToString()}");
                        Desert desert = new Desert(difficulty);
                        Console.WriteLine("\n");
                        Console.WriteLine(desert.description);
                        Console.WriteLine($"\n\t------------------------------------------------------------------------------");
                        switch (enemyrand)
                        {
                            case 0:
                                Console.WriteLine($"\n\tA goblin crawls out of the bushes");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Goblin goblin = new Goblin(player.level, difficulty);
                                combat.Fight(ref player, goblin);
                                break;
                            case 1:
                                Console.WriteLine($"\n\tAn orc stands ready to fight");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Orc orc = new Orc(player.level, difficulty);
                                combat.Fight(ref player, orc);
                                break;
                            case 2:
                                Console.WriteLine($"\n\tAn ogre looms over you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Ogre ogre = new Ogre(player.level, difficulty);
                                combat.Fight(ref player, ogre);
                                break;
                            case 3:
                                Console.WriteLine($"\n\tA dragon swoops in smashing to the ground in front of you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Dragon dragon = new Dragon(player.level, difficulty);
                                combat.Fight(ref player, dragon);
                                break;
                            case 4:
                                Console.WriteLine($"\n\tA wizard materializes in front of you in a pillar of fire");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                EvilWizard wizard = new EvilWizard(player.level, difficulty);
                                combat.Fight(ref player, wizard);
                                break;
                            default:
                                Boss boss = new Boss(player.level, difficulty);
                                Console.WriteLine($"\n\t{boss.ename} narrowly misses you as you enter the area. {boss.ename} says,'Finally, {player.name}. I was beginning to think you weren't coming'.");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                combat.Fight(ref player, boss);
                                break;
                        }
                        Console.WriteLine(desert.description);
                        Console.WriteLine($"\n------------------------------------------------------------------------------");
                        //List<string> commands = forest.commands();
                        Console.WriteLine("Onward!\n\t{Press any key to continue}");
                        Console.ReadKey();
                        break;
                    case RoomType.Cave:
                        Console.WriteLine($"You are now entering a {biome.ToString()}");
                        Cave cave = new Cave(difficulty);
                        Console.WriteLine("\n");
                        Console.WriteLine(cave.description);
                        Console.WriteLine($"\n------------------------------------------------------------------------------");
                        switch (enemyrand)
                        {
                            case 0:
                                Console.WriteLine($"\n\tA goblin crawls out of the bushes");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Goblin goblin = new Goblin(player.level, difficulty);
                                combat.Fight(ref player, goblin);
                                break;
                            case 1:
                                Console.WriteLine($"\n\tAn orc stands ready to fight");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Orc orc = new Orc(player.level, difficulty);
                                combat.Fight(ref player, orc);
                                break;
                            case 2:
                                Console.WriteLine($"\n\tAn ogre looms over you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Ogre ogre = new Ogre(player.level, difficulty);
                                combat.Fight(ref player, ogre);
                                break;
                            case 3:
                                Console.WriteLine($"\n\tA dragon swoops in smashing to the ground in front of you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Dragon dragon = new Dragon(player.level, difficulty);
                                combat.Fight(ref player, dragon);
                                break;
                            case 4:
                                Console.WriteLine($"\n\tA wizard materializes in front of you in a pillar of fire");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                EvilWizard wizard = new EvilWizard(player.level, difficulty);
                                combat.Fight(ref player, wizard);
                                break;
                            default:
                                Boss boss = new Boss(player.level, difficulty);
                                Console.WriteLine($"\n\t{boss.ename} narrowly misses you as you enter the area. {boss.ename} says,'Finally, {player.name}. I was beginning to think you weren't coming'.");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                combat.Fight(ref player, boss);
                                break;
                        }
                        Console.WriteLine(cave.description);
                        Console.WriteLine($"\n------------------------------------------------------------------------------");
                        //List<string> commands = forest.commands();
                        Console.WriteLine("Onward!\n\t{Press any key to continue}");
                        Console.ReadKey();
                        break;
                    case RoomType.Dungeon:
                        Console.WriteLine($"You are now entering a {biome.ToString()}");
                        Dungeon dungeon = new Dungeon(difficulty);
                        Console.WriteLine("\n");
                        Console.WriteLine(dungeon.description);
                        Console.WriteLine($"\n------------------------------------------------------------------------------");
                        switch (enemyrand)
                        {
                            case 0:
                                Console.WriteLine($"\n\tA goblin crawls out of the bushes");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Goblin goblin = new Goblin(player.level, difficulty);
                                combat.Fight(ref player, goblin);
                                break;
                            case 1:
                                Console.WriteLine($"\n\tAn orc stands ready to fight");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Orc orc = new Orc(player.level, difficulty);
                                combat.Fight(ref player, orc);
                                break;
                            case 2:
                                Console.WriteLine($"\n\tAn ogre looms over you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Ogre ogre = new Ogre(player.level, difficulty);
                                combat.Fight(ref player, ogre);
                                break;
                            case 3:
                                Console.WriteLine($"\n\tA dragon swoops in smashing to the ground in front of you");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                Dragon dragon = new Dragon(player.level, difficulty);
                                combat.Fight(ref player, dragon);
                                break;
                            case 4:
                                Console.WriteLine($"\n\tA wizard materializes in front of you in a pillar of fire");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                EvilWizard wizard = new EvilWizard(player.level, difficulty);
                                combat.Fight(ref player, wizard);
                                break;
                            default:
                                Boss boss = new Boss(player.level, difficulty);
                                Console.WriteLine($"\n\t{boss.ename} narrowly misses you as you enter the area. {boss.ename} says,'Finally, {player.name}. I was beginning to think you weren't coming'.");
                                Console.WriteLine("FIGHT!\n\t{Press any key to continue}");
                                Console.ReadKey();
                                combat.Fight(ref player, boss);
                                break;
                        }
                        Console.WriteLine(dungeon.description);
                        Console.WriteLine($"\n------------------------------------------------------------------------------");
                        //List<string> commands = forest.commands();
                        Console.WriteLine("Onward!\n\t{Press any key to continue}");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                if (player.health < 1)
                {
                    break;
                }
            }
        }
    }
}
