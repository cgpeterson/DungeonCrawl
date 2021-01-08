using System;
using System.Collections.Generic;

namespace Classes
{
    class Cave : Room
    {
        public string description { get; }
        public string name { get; }

        public Cave(int difficulty)
        {
            Random rand = new Random();

            difficulty++;

            if (rand.Next() % difficulty == 0)
            {
                description = "The dark of this cave seems too close to you ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description = "Vegatation hangs from the cave top here ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description = "The rocks here are sharp and jagged ";
            }
            else
            {
                description = "A gentle stream runs through the middle of this area ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "a faint whisper of air seems to be dancing about you. ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "Something brushes past your feet unseen in the darkness. ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "it feels as though the cave walls are sneering at you. ";
            }
            else
            {
                description += "the sound of dripping water resonates throughout the area. ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "It feels ominous in here as though you are being watched.";
                name = "Ominous Dark";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "The very walls seem to be out to get you.";
                name = "Calm Forest";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "The shapes of some rock formations make the cave seem alive.";
                name = "Dark Woods";
            }
            else
            {
                description += "The moist air and lack of sound make you feel as if you were swallowed.";
                name = "Sacred Grove";
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
