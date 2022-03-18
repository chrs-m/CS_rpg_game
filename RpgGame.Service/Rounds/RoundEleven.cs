namespace RpgGame.Service.Rounds;

public class RoundEleven : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundEleven(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}