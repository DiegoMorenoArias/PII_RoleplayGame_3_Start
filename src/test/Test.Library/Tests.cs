using System;
using NUnit.Framework;
using RoleplayGame;
using System.Collections.Generic;

namespace Test.Library
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestArcherAttackValue()
        {
            const int expected = 15;
            Archer archer = new Archer("Arquero1");
            Assert.AreEqual(expected, archer.AttackValue);
        }

        [Test]
        public void TestArcherDefenseValue()
        {
            const int expected = 18;
            Archer archer = new Archer("Archer1");
            Assert.AreEqual(expected, archer.DefenseValue);
        }

        [Test]
        public void TestDwarfAttackValue()
        {
            const int expected = 25;
            Dwarf dwarf = new Dwarf("Dwarf1");
            Assert.AreEqual(expected, dwarf.AttackValue);
        }

        [Test]
        public void TestDwarfDefenseValue()
        {
            const int expected = 18;
            Dwarf dwarf = new Dwarf("Dwarf1");
            Assert.AreEqual(expected, dwarf.DefenseValue);
        }

        [Test]
        public void TestKnightAttackValue()
        {
            const int expected = 20;
            Knight knight = new Knight("Knight1");
            Assert.AreEqual(expected, knight.AttackValue);
        }

        [Test]
        public void TestKnightDefenseValue()
        {
            const int expected = 39;
            Knight knight = new Knight("Knight1");
            Assert.AreEqual(expected, knight.DefenseValue);
        }

        [Test]
        public void TestWizardAttackValue()
        {
            const int expected = 100;
            Wizard wizard = new Wizard("Wizard1");
            Assert.AreEqual(expected, wizard.AttackValue);
        }

        [Test]
        public void TestWizardDefenseValue()
        {
            const int expected = 100;
            Wizard wizard = new Wizard("Wizard1");
            Assert.AreEqual(expected, wizard.DefenseValue);
        }

        [Test]
        public void TestReceiveAttack()
        {
            const int expected = 98;
            Dwarf dwarf = new Dwarf("Dwarf1");
            Knight knight = new Knight("Knight1");
            dwarf.ReceiveAttack(knight.AttackValue);
            Console.WriteLine(knight.AttackValue);
            Console.WriteLine(dwarf.DefenseValue);
            Assert.AreEqual(expected, dwarf.Health);
        }

        [Test]
        public void TestEncounter()
        {
            Enemy enemy1 = new Enemy(1);
            Enemy enemy2 = new Enemy(2);
            Wizard wizard1 = new Wizard("wizard1");
            Wizard wizard2 = new Wizard("wizard2");
            DoEncounter(new List<Hero>{wizard1, wizard2}, new List<Enemy>{enemy1, enemy2});
            const int expected = 100;
            Assert.AreEqual(expected, wizard1.Health);
        }
    }
}