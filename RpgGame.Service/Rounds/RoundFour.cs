namespace RpgGame.Service.Rounds;

public class RoundFour : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundFour(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        IO.Out("Hello");
        
        //message
        //choice
        //events
        //outcome
        //move on
    }
}