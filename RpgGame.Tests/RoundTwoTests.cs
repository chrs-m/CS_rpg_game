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
        Player player = new Player("Test player", 23, new Weapon("Trasig käpp", 5, ""), 0);

        IO.Buffer.Enqueue("5");
        IO.Buffer.Enqueue("2");

        RoundTwo round = new RoundTwo(player);
        round.StartRound();

        Assert.AreEqual("Trasig käpp", player.Weapon.Name);
        
    }
}