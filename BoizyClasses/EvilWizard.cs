using System;

namespace Classes
{
    public class EvilWizard : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 25;
        int _speed = 13;
        public Name name;

        public EvilWizard(int level, int difficulty)
        {
            Random rand = new Random();
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 25 + (4 * level) + (2 * difficulty);
            coins = 5 + (6 * level) + (2 * difficulty);
            experience = 6 + (6 * level) + (2 * difficulty);
            damage = _damage + (4 * level) + (2 * difficulty);
            name = (Name)(rand.Next() % 5);
            ename = name.ToString();
        }

        public enum Name
        {
            Zolinder,
            Voldimar,
            Yuntar,
            Toblin,
            Cody
        }

        public void Display()
        {
            Console.WriteLine("A robed figure steps out of the shadows. Cloaked in shimmering cloth this creature use to be human. The form before you has been twisted by dark magics" + name.ToString() + " is here.");
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
