namespace Jogo_rpg
{
    public abstract class Heroes
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroeType { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public Heroes(string name, int level, string herotype, int mp, int hp)
        {
            this.Name = name;
            this.Level = level;
            this.HeroeType = herotype;
            this.Mp = mp;
            this.Hp = hp;
        }

        public virtual string Attack()
        {
            return Name + "Atacou com sua arma";
        }
        
        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return Name + " Realizou um ataque extremamente efetivo com bonus de " + bonus;
            }
            else
            {
                return Name + " Realizou um ataque fraco, com bonus de " + bonus;
            }
            
        }

        public override string ToString()
        {
            return Name + " " + Level + " " + HeroeType;
        }
    }
}