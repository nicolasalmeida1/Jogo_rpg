namespace Jogo_rpg
{
    public class Wizard : Heroes
    {
        public Wizard(string name, int level, string herotype, int hp, int mp) : base(name, level, herotype, hp, mp)
        {
        }

        public override string Attack()
        {
            return Name + " Lançou uma magia";
        }

    }
}