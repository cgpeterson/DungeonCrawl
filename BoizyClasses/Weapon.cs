namespace Classes
{
    public class Weapon : Item
    {

        public string name { get; }
        public int cost { get; }

        public enum Type
        {
            Rapier,
            Axe,
            Club
        }

        int _damage;
        int _speed;

        public Type type;

        public Weapon(string nameWeapon, int coinsRequired, Type weaponType, int damageNum, int speedNum)
        {
            name = nameWeapon;
            cost = coinsRequired;
            type = weaponType;
            _damage = damageNum;
            _speed = speedNum;
        }
        public int Attack()
        {
            return _damage;
        }
        public int Speed()
        {
            return _speed;
        }
    }
}
