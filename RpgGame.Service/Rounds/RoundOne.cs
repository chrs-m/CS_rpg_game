namespace RpgGame.Service.Rounds;
using RpgGame.Service;
public class RoundOne : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    private Player Player;
    
    public RoundOne(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1000;
        
        IO.Out($"Välkommen {Player.Name}!");
        //Thread.Sleep(ms);
        IO.Out("Du vaknar upp lite halvtrasig i slottskogen efter en utekväll..");
        //Thread.Sleep(ms);
        IO.Out($"Bredvid dig hittar du {Items.Weapons[0].Name}({Items.Weapons[0].Damage}dmg) och en {Items.Food[0].Name}.");
        //Thread.Sleep(ms);
        IO.Out($"{Items.Food[0].Name} ger dig lite extra energi ({Items.Food[0].Modifier}).");

        Player.Weapon = Items.Weapons[0];
        Player.Consume(Items.Food[0]);
        
        //Thread.Sleep(ms);
        IO.Out($"Du har nu {Player.Hp}hp och ditt vapen är {Player.Weapon.Name} ({Player.Weapon.Damage}dmg).");

       IO.Out("");
        while (true)
        {
            IO.Out("1. Gå vidare");
            int choosen = IO.IntIn("");

            if (choosen == 1)
            {
                break;
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            IO.Out("Hint, det är 1...: ", true);
            Console.ResetColor();
        }
    }
}