using System;

namespace Jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Alucard = new Knight("Alucard", 20, "Knight", 100, 50);
            Wizard Gendalf = new Wizard("Gendalf", 35, "Mage", 100, 50);
            BlackWizard Warlock = new BlackWizard("Warlock", 23, "Mage", 85, 60);
            Ninja Rogue = new Ninja("Rogue", 26, "Assassin", 45, 40);


        }
    }
}
