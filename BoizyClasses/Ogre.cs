using System;

namespace Classes
{
    public class Ogre : Enemy
    {
        public int health { get; set; }
        public int speed { get; }
        public int damage { get; }
        public string ename { get; }
        public int coins { get; }
        public int experience { get; }

        int _maxhealth;
        int _damage = 20;
        int _speed = 5;

        public Ogre(int level, int difficulty)
        {
            speed = _speed + (2 * level) + (2 * difficulty);
            health = 25 + (4 * level) + (2 * difficulty);
            coins = 4 + (4 * level) + (2 * difficulty);
            experience = 4 + (4 * level) + (2 * difficulty);
            damage = _damage + (3 * level) + (2 * difficulty);
            ename = "the ogre";
        }

        public void Display()
        {
            Console.WriteLine("Looming over you this large figure is anything but human. The huge creature is more mountain than man and is carrying a club the size of a tree.");
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
