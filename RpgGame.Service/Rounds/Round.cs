namespace RpgGame.Service.Rounds;

using RpgGame.Service;

public class Round
{
     public int RoundNum { get; }
     public string RoundType { get; }
     public virtual void StartRound() { }
     
}