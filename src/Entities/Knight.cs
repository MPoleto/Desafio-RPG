namespace RPG.src.Entities
{
    public class Knight : Hero
    {
       
         public Knight(string name, string heroType, int level, int maxHP, int maxMP, string weapon) : base (null, null, 0, 0, 0, null)
        {
            this.name = name;
            this.heroType = heroType;
            this.level = level;
            this.maxHP = maxHP;
            this.maxMP = maxMP;
            this.weapon = weapon;
        }

        public override string Attack()
        {
            return this.name + " attacked with a sword";
        }

    }
}