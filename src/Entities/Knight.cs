namespace RPG.src.Entities
{
    public class Knight : Hero
    {
       
         public Knight(string name, string heroType, int level, int maxHP, int maxMP, string weapon) : base (name, heroType, level, maxHP, maxMP, weapon)
        {
        }

        public override string Attack()
        {
            return this.name + " attacked with a sword";
        }

    }
}