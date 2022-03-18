namespace RpgGame.Service.Rounds;

public class RoundTen : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundTen(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}