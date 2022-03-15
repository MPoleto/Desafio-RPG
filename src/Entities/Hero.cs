namespace RPG.src.Entities
{
    public abstract class Hero
    {
             
        public Hero(string name, string heroType, int level, int maxHP, int maxMP, string weapon) 
        {
            this.name = name;
            this.heroType = heroType;
            this.level = level;
            this.maxHP = maxHP;
            this.maxMP = maxMP;
            this.weapon = weapon;
        }
             
        
        public string name;
        public string heroType;
        public int level;
        public int maxHP;
        public int maxMP;
        public string weapon;


        public override string ToString()
        {
            return this.name + " - " + this.heroType + "\n" 
            + "Level " + this.level + "\n" 
            + "Max HP " + this.maxHP + "\n" 
            + "Max MP " + this.maxMP + "\n" 
            + "Weapon " + " - " + this.weapon;    
        }


        public virtual string Attack() 
        {
            return this.name + " attacked";
        }
       
    }
}