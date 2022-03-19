namespace RpgGame.Service;

public class Coins
{
    public string Name { get; }
    public int Modifier { get; }

    public Coins(string name, int modifier)
    {
        Name = name;
        Modifier = modifier;
    }
}