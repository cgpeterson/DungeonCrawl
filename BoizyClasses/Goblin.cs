using System;

namespace Classes
{
    public class Goblin : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 5;
        int _speed = 20;

        public Goblin(int level, int difficulty)
        {
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 15 + (2 * level) + (2 * difficulty);
            coins = 2 + (2 * level) + (2 * difficulty);
            experience = 2 + (2 * level) + (2 * difficulty);
            damage = _damage + (2 * level) + (2 * difficulty);
            _maxhealth = health;
            ename = "the goblin";
        }

        public void Display()
        {
            Console.WriteLine("This small green ball of anger, in some fashion, resembles a child. However, you can quickly discern it is a goblin by the wrinkly green skin and large head.");
        }

        public string Condition()
        {
            string econdition = string.Empty;
            if (health > (_maxhealth / 2 + (_maxhealth / 4)))
            {
                econdition = "The goblin looks fresh and ready for a fight.";
            }
            else if (health > _maxhealth / 2)
            {
                econdition = "Brusing is appearing on the goblin's face and he looks less eager";
            }
            else if (health > _maxhealth / 4)
            {
                econdition = "The goblin is infuriated. He is looking quite bloody";
            }
            else if (health < _maxhealth / 4)
            {
                econdition = "The gobin seems to be panicing. Death is soon for him";
            }
            return econdition;
        }
    }
}
