namespace Classes
{
    public interface Enemy
    {
        int health { get; set; }
        int speed { get; }
        int damage { get; }
        string ename { get; }
        int coins { get; }
        int experience { get; }
        void Display();

        string Condition();
    }
}
