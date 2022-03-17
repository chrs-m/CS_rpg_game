namespace RpgGame.Service;

public class Weapon
{
    public string Name { get; }
    public int Damage { get; }
    public string Description { get; }
    public int? Price { get; }

    public Weapon(string name, int damage, string description, int? price = null)
    {
        Name = name;
        Damage = damage;
        Description = description;
        Price = price;
    }
}