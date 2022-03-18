namespace RpgGame.Service.Rounds;

public class RoundTwo : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundTwo(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}