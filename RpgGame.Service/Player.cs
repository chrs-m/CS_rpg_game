namespace RpgGame.Service;

public class Player
{
    public string Name { get; }
    public int Hp { get; set; }
    public Weapon Weapon { get; set; }

    public Player(string name, int hp, Weapon weapon)
    {
        Name = name;
        Hp = hp;
        Weapon = weapon;
    }

    public void Consume(Food food)
    {
        Hp += food.Modifier;
    }
}