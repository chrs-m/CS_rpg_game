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
        var ms = 1000;

        IO.Out("Du traskar vidare upp emot 'Vita villan'..");
        //Thread.Sleep(ms);
        IO.Out("På avstånd ser du en person som kanske fått i sig något olagligt..");
        //Thread.Sleep(ms);
        IO.Out($"Han viftar friskt med vad som ser ut som på avstånd ser ut som en {Items.Enemies[0].Weapon.Name}.");
        IO.Out("");
        //Thread.Sleep(ms);
        IO.Out(
            $"När du närmar dig så ser du att det är '{Items.Enemies[0].Name}' från hamnen som står där och viftar med sin {Items.Enemies[0].Weapon.Name}");
        IO.Out($"När '{Items.Enemies[0].Name}' får syn på dig börjar han vråla om att utmana dig i en duell..");
        IO.Out("");


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out($"Vill du anta duellen mot '{Items.Enemies[0].Name}'?");
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("[1] för att anta -- [2] för att låta bli");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var inputAnswerDuel = IO.IntIn("Gör ditt val: ");
            Console.ResetColor();

            if (inputAnswerDuel != 1)
            {
                IO.Out("", true);
                Console.ForegroundColor = ConsoleColor.Magenta;
                IO.Out($"Ledsen, men du kommer inte förbi '{Items.Enemies[0].Name}' utan att anta duellen..");
                IO.Out("");
                Console.ResetColor();
            }

            if (inputAnswerDuel == 1)
            {
                IO.Out("", true);
                IO.Out($"Dags för din första duell!");
                break;
            }
        }

        Duel duel = new Duel(Player, Items.Enemies[0]);
        var winner = duel.startDuel();

        if (winner == "player")
        {
            //fortsätt storyn..
        }
        else
        {
            IO.Out("You dead man. Sorry.");
            Game.GameOver();
        }

        //message
        //choice
        //events
        //outcome
        //move on
    }
}