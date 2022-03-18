namespace RpgGame.Service.Rounds;

public class RoundSeven : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundSeven(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}