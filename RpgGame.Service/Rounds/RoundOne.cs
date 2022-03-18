namespace RpgGame.Service.Rounds;
using RpgGame.Service;
public class RoundOne : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }

    public override void StartRound()
    {
        var ms = 1000;
        
        IO.Out($"Välkommen {Player.name}!");
        Thread.Sleep(ms);
        IO.Out("Du vaknar upp lite halvtrasig i slottskogen efter en utekväll..");
        Thread.Sleep(ms);
        IO.Out($"Bredvid dig hittar du {Items.Weapons[0]}({Items.Weapons[0].Damage}dmg) och en {Items.Food[0]}.");
        Thread.Sleep(ms);
        IO.Out($"{Items.Food[0]} ger dig lite extra energi ({Items.Food[0].Modifier}).");

        Console.WriteLine();
        IO.Out("1. Gå vidare");
        IO.IntIn("");
    }
}