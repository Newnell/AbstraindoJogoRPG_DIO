namespace LastWar.SRC.Entities
{
    public class Healer : Hero
    {
         public Healer(string name, int level, string heroType, string skill, int strength, int dexterity, int intelligence, int constitution, int hp, int mp)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.skill = skill;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.hp = hp;
            this.mp = mp;
        } 
        public Healer()
        {

        }              
         
    }
}