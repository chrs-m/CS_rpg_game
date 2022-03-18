namespace RpgGame.Service.Rounds;

public class RoundTwelve : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundTwelve(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}