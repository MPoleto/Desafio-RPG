namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, string heroType, int level, int maxHP, int maxMP, string weapon) : base (name, heroType, level, maxHP, maxMP, weapon)
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
            return this.name + " attacked with a kunai";
        }

    }
}