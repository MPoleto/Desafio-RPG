namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, string heroType, int level, int maxHP, int maxMP, string weapon) : base (name, heroType, level, maxHP, maxMP, weapon)
        {
        }

        public override string Attack()
        {
            return this.name + " attacked with a kunai";
        }

    }
}