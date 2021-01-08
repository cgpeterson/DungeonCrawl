using System;
using System.Collections.Generic;

namespace Classes
{
    public class Forest : Room
    {
        public string description { get; }
        public string name { get; }

        public Forest(int difficulty)
        {
            Random rand = new Random();

            difficulty++;

            if (rand.Next() % difficulty == 0)
            {
                description = "\tThe pines here stand tall and straight ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description = "\tThese towering fir shade the morning in this area ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description = "\tThis aspen grove is thick and short. The twisted barren trees cover this slope ";
            }
            else
            {
                description = "\tA scattering of great oak trees cover this meadow ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "fresh dew resting on the buds and branches. ";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "the dim light casts dancing shadows throughout the glen. ";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "small creatures skitter up trees and along the forest floor. ";
            }
            else
            {
                description += "a magestic elk is watching you from a distance illuminated by shafts of light through the trees. ";
            }

            if (rand.Next() % difficulty == 0)
            {
                description += "It feel very peaceful here";
                name = "Peaceful Woodland";
            }
            else if (rand.Next() % difficulty == 1)
            {
                description += "The calm crisp air is unsettlingly quiet.";
                name = "Calm Forest";
            }
            else if (rand.Next() % difficulty == 2)
            {
                description += "The shapes of some trees give an erie feel to this dim forest.";
                name = "Dark Woods";
            }
            else
            {
                description += "You feel as though you are trespassing on sacred land.";
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
