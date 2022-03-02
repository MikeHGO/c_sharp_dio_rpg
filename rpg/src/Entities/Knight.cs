namespace rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public Knight() { }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.name + " magia super efetiva com bonus de " + bonus;
            }
            else
            {
                return this.name + " magia com bonus de " + bonus;

            }
        }
    }
}