namespace RpgGame.Service.Rounds;

public class RoundFive : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundFive(Player player)
    {
        Player = player;
    }

    public override void StartRound() { }
}