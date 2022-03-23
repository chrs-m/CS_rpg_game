namespace RpgGame.Service;

public class Duel
{
    private Player Player { get; }
    private Enemy Enemy { get; }

    public Duel(Player player, Enemy enemy)
    {
        Enemy = enemy;
        Player = player;
    }

    public string startDuel() // return "player"|"enemy"
    {
        var ms = 1000;
        while (Player.Hp > 0 && Enemy.Hp > 0)
        {
            //Player attack
            IO.Out($"Du attackarade {Enemy.Name} med {Player.Weapon.Name}.");
            //Thread.Sleep(ms);
            IO.Out($"{Enemy.Name} tog {Player.Weapon.Damage}hp i skada");
            //Thread.Sleep(ms);
            Enemy.Hp -= Player.Weapon.Damage; 
            IO.Out($"{Enemy.Name} har nu {Enemy.Hp} hp kvar");
            //Thread.Sleep(ms);
            IO.Out("");


            if (Enemy.Hp <= 0)
                break;

            //Enemy attack
            IO.Out($"{Enemy.Name} attackarade dig med {Enemy.Weapon.Name}.");
            //Thread.Sleep(ms);
            IO.Out($"Du tog {Enemy.Weapon.Damage}hp i skada");
            //Thread.Sleep(ms);
            Player.Hp -= Enemy.Weapon.Damage; 
            IO.Out($"Du har nu {Player.Hp} hp kvar");
            //Thread.Sleep(ms);
            IO.Out("");


            if (Player.Hp <= 0)
                break;
            //Player attack enemy, check hp, print attack
            //Enemy attack player, check hp, print attack
            //hp < 0, return winner
        }

        if (Player.Hp <= 0)
        {
            return "enemy";
        }

        return "player";
    }
}