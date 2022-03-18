namespace RpgGame.Service.Rounds;

public class RoundNine : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundNine(Player player)
    {
        Player = player;
    }
    
    public override void StartRound() { }
}