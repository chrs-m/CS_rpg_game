namespace RpgGame.Service.Rounds;

public class RoundSix : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundSix(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}