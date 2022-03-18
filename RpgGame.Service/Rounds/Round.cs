namespace RpgGame.Service.Rounds;

public class Round
{

     public int RoundNum { get; }
     public string RoundType { get; }
     public virtual void StartRound() { }
     
}