namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, string heroType, int level, int maxHP, int maxMP, string weapon): base (name, heroType, level, maxHP, maxMP, weapon)
        {
        }


        public override string Attack()
        {
            return this.name + " magic attack";    
        }

        public string Attack(int bonus)
        {
            if (bonus > 6) 
            {
                return this.name + " used a super effective magic attack + " + bonus + " bonus";
            }
            else
            {
                return this.name + " used a magic attack + " + bonus + " bonus";
            }
        }
    }
}