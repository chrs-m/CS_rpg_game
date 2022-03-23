using System.Globalization;

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

        var random = new Random();
        int index = random.Next(Items.Coins.Count);
        var randomCoins = Items.Coins[index];

        IO.Out(
            $"När du vandrar vidare mot August Kobbs damm så ser du en {randomCoins.Name} på gatan som någon verkar ha tappat.");
        IO.Out($"Vill du plocka upp {randomCoins.Name} eller låta den ligga kvar på marken?");
        Console.ForegroundColor = ConsoleColor.Green;
        IO.Out("[1] för att plocka upp -- [2] för att låta den ligga");
        Console.ForegroundColor = ConsoleColor.Cyan;
        var inputAnswerCoins = IO.IntIn("Gör ditt val: ");
        Console.ResetColor();

        if (inputAnswerCoins == 1)
        {
            IO.Out("", true);
            Player.GetCoins(randomCoins);

            if (randomCoins.Modifier <= 0)
            {
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                IO.Out(
                    $"Börsen var trasig och det låg inga mynt kvar inuti. Du har fortfarande {Player.Coins} kronor på fickan.");
                Console.ResetColor();
                IO.Out("");
            }

            if (randomCoins.Modifier > 1)
            {
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out(
                    $"Du öppnande börsen och såg att det låg {randomCoins.Modifier} kronor inuti. Du har nu {Player.Coins} kronor på fickan.");
                Console.ResetColor();
                IO.Out("");
            }
        }

        if (inputAnswerCoins == 2)
        {
            IO.Out("", true);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            IO.Out($"Du valde att slänga in {randomCoins.Name} i buskarna för någon annan att hitta.");
            Console.ResetColor();
        }

        while (true)
        {
            if (Player.Hp > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out("Vill du leta efter en till börs eller gå vidare?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                IO.Out("[1] för att leta -- [2] för att gå vidare");
            }

            int choosen = IO.IntIn("");
            Console.ResetColor();

            if (choosen == 2)
            {
                break;
            }

            var Girighet = new Food("Girighet", -2);
            Player.Hp += Girighet.Modifier;

            IO.Out("", true);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out("Med ögonen i backen virrar du omkring utan resultat, rakt in i skogen och du är vilse..");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            IO.Out($"Din girighet kostade dig  2hp. Du har nu {Player.Hp}hp kvar.");
            IO.Out("");
            Console.ResetColor();

            if (Player.Hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                IO.Out("Din girighet kostade dig livet..", true);
                Console.ForegroundColor = ConsoleColor.Red;
                IO.Out($"Tack för att du spelade, {Player.Name}!");
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                IO.Out("Tryck [9] för att börja om..");
                Console.ResetColor();

                if (choosen == 9)
                {
                    Game.GameOver();
                }
            }
        }
    }
}