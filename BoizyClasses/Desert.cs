using System;
using System.Collections.Generic;

namespace Classes
{
    class Desert : Room
    {
        public string description { get; }
        public string name { get; }

        public Desert(int difficulty)
        {
            Random rand = new Random();

            difficulty++;

            if (rand.Next() % difficulty == 0)
            {
                description = "The rolling dunes seem to sprawl for miles ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description = "You find a small oasis sparce life has begun to grow ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description = "The landscape here hints at what use to be a city ";
            }
            else
            {
                description = "Rubble remain here of an abandoned caravan nothing remains but scraps ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "the heat causing the surrounding sand to waver. ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "lizards and other small creatures scurry about the sand. ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "a large bird sits on a nearby cactus picking at a bone. ";
            }
            else
            {
                description += "the skull of what was once a massive animal rests half covered in sand here. ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "It feel very peaceful here";
                name = "Peaceful Dune";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "The sweltering moist air is unsettlingly quiet.";
                name = "Calm Expanse";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "The roaring wind seems to carry the screams of the dying.";
                name = "Haunting Howls";
            }
            else
            {
                description += "You feel as though you will never get all the sand out of your ears.";
                name = "Sandy Ass";
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
