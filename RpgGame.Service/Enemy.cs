namespace RpgGame.Service;

public class Enemy
{
    public string Name { get; }
    public int Hp { get; set; }
    public Weapon Weapon { get; }
    
    public string Type { get; }

    public Enemy(string name, int hp, string type, Weapon weapon)
    {
        Name = name;
        Hp = hp;
        Weapon = weapon;
        Type = type;
    }
}