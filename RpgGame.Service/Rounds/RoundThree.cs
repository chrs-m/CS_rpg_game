namespace RpgGame.Service.Rounds;

public class RoundThree : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundThree(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1000;
        IO.Out("Hello");
        
        
        //message
        //choice
        //events
        //outcome
        //move on
    }
}