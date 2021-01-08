using System;

namespace Classes
{
    public class Orc : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 10;
        int _speed = 10;

        public Orc(int level, int difficulty)
        {
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 20 + (3 * level) + (2 * difficulty);
            coins = 3 + (3 * level) + (2 * difficulty);
            experience = 3 + (3 * level) + (2 * difficulty);
            damage = _damage + (2 * level) + (2 * difficulty);
            ename = "the orc";
        }

        public void Display()
        {
            Console.WriteLine("This bulky humanoid stand about the same height as a man while hunched. His blackened skin and snarling face stare back at you past large tusks.");
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
