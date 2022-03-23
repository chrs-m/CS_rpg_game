namespace RpgGame.Service;

public class Player
{
    public string Name { get; }
    public int Hp { get; set; }
    public Weapon Weapon { get; set; }
    
    public int Coins { get; set; }

    public Player(string name, int hp, Weapon weapon, int coins)
    {
        Name = name;
        Hp = hp;
        Weapon = weapon;
        Coins = coins;
    }

    public void Consume(Food food)
    {
        Hp += food.Modifier;
        Coins -= food.Price;
    }

    public void GetCoins(Coins coins)
    {
        Coins += coins.Modifier;
    }
}