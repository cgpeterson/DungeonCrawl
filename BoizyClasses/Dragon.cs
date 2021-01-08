using System;

namespace Classes
{
    public class Dragon : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 30;
        int _speed = 8;
        public Name name;

        public Dragon(int level, int difficulty)
        {
            Random rand = new Random();
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 35 + (5 * level) + (2 * difficulty);
            coins = 20 + (5 * level) + (2 * difficulty);
            experience = 5 + (5 * level) + (2 * difficulty);
            damage = _damage + (2 * level) + (2 * difficulty);
            name = (Name)(rand.Next() % 7);
            ename = name.ToString();
        }

        public enum Name
        {
            Volgir,
            Sanizar,
            Yarzi,
            Thanidor,
            Crusher,
            Spike,
            Cody
        }

        public void Display()
        {
            Console.WriteLine("Before you is a stunning giant dragon. It's gemtone scales glint in the light and its huge wings lay flat against its back." + name.ToString() + " is here.");
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
