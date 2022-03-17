namespace RpgGame.Service;

public class Player
{
    public string Name { get; }
    public int Hp { get; }
    public Weapon Weapon { get; }

    public Player(string name, int hp, Weapon weapon)
    {
        Name = name;
        Hp = hp;
        Weapon = weapon;
    }
}