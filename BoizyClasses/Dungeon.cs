using System;
using System.Collections.Generic;

namespace Classes
{
    class Dungeon : Room
    {
        public string description { get; }
        public string name { get; }

        public Dungeon(int difficulty)
        {
            Random rand = new Random();

            difficulty++;

            if (rand.Next() % difficulty == 0)
            {
                description = "The walls of this once great room are now laid low ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description = "The room was a sight to see many eons ago ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description = "Skeletons litter the floor of this large chamber ";
            }
            else
            {
                description = "The dusty marble and carved pillars hint at a culture lost to time ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "vegatation has taken over this chamber now growing up between the flagstones. ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "weapons once adorned the walls of this room now only the racks remain. ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "tables fill this room collapsing from mold and damp. ";
            }
            else
            {
                description += "a great throne sits smashed at the other end of this room. ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "It feel very peaceful here";
                name = "Peaceful room";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "The calm crisp air is unsettlingly quiet.";
                name = "Calm weapon room";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "The blood stained wood furniture in here gives it a deathly smell.";
                name = "Dark chamber";
            }
            else
            {
                description += "You feel as though you are trespassing on sacred ground.";
                name = "Sacred throne room";
            }
        }

        public List<string> commands()
        {
            Random rand = new Random();
            List<string> directions = new List<string>();

            //Direction Randomizer
            for (int i = 0; i < 4; i++)
            {
                switch (rand.Next() % 10)
                {
                    case (0):
                        directions.Add("North(n), ");
                        break;
                    case (1):
                        directions.Add("North-East(ne), ");
                        break;
                    case (2):
                        directions.Add("East(e), ");
                        break;
                    case (3):
                        directions.Add("South-East(se), ");
                        break;
                    case (4):
                        directions.Add("South(s), ");
                        break;
                    case (5):
                        directions.Add("South-West(sw), ");
                        break;
                    case (6):
                        directions.Add("West(w), ");
                        break;
                    case (7):
                        directions.Add("North-West(nw), ");
                        break;
                    default:
                        break;
                }
            }

            return directions;
        }
    }
}
