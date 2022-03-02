namespace rpg.src.Entities
{
    public class Mage : Hero
    {
        public Mage(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Mage() { }
        public override string Attack()
        {
            return this.name + " Atacou com a sua magia";
        }

        public string Attack(int bonus)
        {
            return this.name + " Lançou magia com bonus de ataque de " + bonus;
        }
    }
}