namespace RpgGame.Service.Rounds;

public class RoundFive : Round
{
    private Player Player;

    public RoundFive(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1300;

        IO.Out("Det börjar bli mörkt och du är trött efter din första duell");
        Thread.Sleep(ms);
        IO.Out("Lite längre fram ligger Barfotaslingan som kan fungera som sovplats för natten.");
        Thread.Sleep(ms);
        IO.Out("");

        while (true)
        {
            IO.Out("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out($"Vill du gå till Barfotaslingan för att sova för natten?");
            IO.Out("");
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("[1] för att sova -- [2] för att låta bli");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var inputAnswerSleep = IO.IntIn("Gör ditt val: ");
            Console.ResetColor();

            if (inputAnswerSleep == 2)
            {
                var Girighet = new Food("Girighet", -5);
                Player.Hp += Girighet.Modifier;

                IO.Out("", true);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                IO.Out("Du är trött och vimsar omkring i skogen och går vilse..");
                IO.Out("");
                Thread.Sleep(ms);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                IO.Out($"Din girighet kostade dig  5hp. Du har nu {Player.Hp}hp kvar.");
                IO.Out($"Vilket inte gav dig någonting för du slocknade av utmattning istället..");
                IO.Out("");
                Console.ResetColor();
                break;
            }

            if (inputAnswerSleep == 1)
            {
                IO.Out("", true);
                break;
            }
        }

        Player.Hp += 5;
        IO.Out("Du somnade gott på en bädd av torkade löv.");
        Thread.Sleep(ms);
        IO.Out("");
        IO.Out("Tack vare att du vilade ut ordentligt så fick du lite extra hp.");
        Thread.Sleep(ms);
        IO.Out($"Du har nu {Player.Hp}hp inför din nästa strid.");


        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        IO.Out("");
        IO.Out("Tryck på en tangent för att gå vidare..");
        IO.AnyIn("");
    }
}