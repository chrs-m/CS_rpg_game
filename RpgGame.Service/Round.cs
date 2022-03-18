namespace RpgGame.Service;

public class Round
{
    private string Message;
    private string Type;

    public Round(string message, string type)
    {
        Message = message;
        Type = type;
    }
    
    public void startRound()
    {
        var milliseconds = 1000;
        // Console.WriteLine($"Välkommen {Player.name}!");
        // Thread.Sleep(milliseconds);
        // Console.WriteLine("Du vaknar upp lite halvtrasig i slottskogen efter en utekväll..");

        //Message
        //Choice
        //Outcome
        //Continue
    }
}