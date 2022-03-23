namespace RpgGame.Service;

public class Food
{
    public string Name { get; }
    public int Modifier { get; }
    
    public int? Price { get; }

    public Food(string name, int modifier, int? price = null)
    {
        Name = name;
        Modifier = modifier;
        Price = price;
    }
}