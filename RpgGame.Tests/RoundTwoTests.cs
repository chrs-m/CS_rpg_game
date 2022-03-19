using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpgGame.Service;
using RpgGame.Service.Rounds;

namespace RpgGame.Tests;

[TestClass]
public class RoundTwoTests
{
    [TestMethod]
    public void StartRound_PlayerHaveWeapon_WeaponNameIs()
    {
        Player player = new Player("Test player", 23, new Weapon("Trasig käpp", 5, ""));

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader("1");
        Console.SetIn(stringReader);

        RoundTwo round = new RoundTwo(player);
        round.StartRound();

        Assert.AreEqual("Trasig käpp", player.Weapon.Name);
        
    }
}