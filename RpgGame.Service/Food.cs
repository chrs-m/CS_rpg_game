namespace RpgGame.Service;

public class Food
{
    public string Name { get; }
    public int Modifier { get; }

    public Food(string name, int modifier)
    {
        Name = name;
        Modifier = modifier;
    }
}