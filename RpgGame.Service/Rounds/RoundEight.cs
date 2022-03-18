namespace RpgGame.Service.Rounds;

public class RoundEight : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundEight(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}