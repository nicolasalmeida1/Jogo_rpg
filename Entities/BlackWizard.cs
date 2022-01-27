namespace Jogo_rpg
{
    public class BlackWizard : Heroes
    {
        public BlackWizard(string name, int level, string herotype, int hp, int mp) : base(name, level, herotype, hp, mp)
        {
        }
        public override string Attack()
        {
            return Name + " Lançou uma bruxaria";
        }
    }
}