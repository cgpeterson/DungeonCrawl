namespace Classes
{
    public class Potion : Item
    {
        public string name { get; }
        public int cost { get; }

        int _healAmount;
        public Potion(string potionName, int value, int coinsRequired)
        {
            name = potionName;
            _healAmount = value;
            cost = coinsRequired;
        }

        public int Heal()
        {
            return _healAmount;
        }
    }
}
