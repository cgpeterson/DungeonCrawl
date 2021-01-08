using System;

namespace Classes
{
    public class Boss : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 25;
        int _speed = 25;
        Name name;

        public Boss(int level, int difficulty)
        {
            Random rand = new Random();
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 100 + (15 * level) + (2 * difficulty);
            coins = 1000 + (50 * level) + (2 * difficulty);
            experience = 20 + (5 * level) + (2 * difficulty);
            damage = _damage + (2 * level) + (2 * difficulty);
            name = (Name)(rand.Next() % 6);
            ename = name.ToString();
        }

        public enum Name
        {
            Andrew,
            Jacob,
            Madison,
            Elizabeth,
            Kaitlynn,
            Cody
        }

        public void Display()
        {
            if (name == Name.Madison || name == Name.Elizabeth || name == Name.Kaitlynn)
            {
                Console.WriteLine("A lithe beautiful figure steps from the darkness. A large sickle in each hand held to the side of a sleek slim gown made of dragonscale." + name.ToString() + " is here.");
            }
            else
                Console.WriteLine("A horible beast tromps out from the darkness. His hideous face looks you up and down as he unsheaths his massive claws. " + name.ToString() + " is here.");
        }

        public string Condition()
        {
            string econdition = string.Empty;
            if (health > (_maxhealth / 2 + (_maxhealth / 4)))
            {
                econdition = $"{ename} looks fresh and ready for a fight.";
            }
            else if (health > _maxhealth / 2)
            {
                econdition = $"Brusing is appearing on {ename}'s face and he looks less eager";
            }
            else if (health > _maxhealth / 4)
            {
                econdition = $"{ename} is infuriated. He is looking quite bloody";
            }
            else if (health < _maxhealth / 4)
            {
                econdition = $"{ename} seems to be panicing. Death is soon for him";
            }
            return econdition;
        }
    }
}
