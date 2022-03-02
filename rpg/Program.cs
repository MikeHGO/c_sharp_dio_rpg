using rpg.src.Entities;
namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage mage = new Mage("Mago", 20, "Maguinho");
            Console.WriteLine(mage.Attack());
            Console.WriteLine(mage.Attack(4));
            Knight cavaleiro = new Knight("Arus", 23, "Guerreiro");

        }
    }
}