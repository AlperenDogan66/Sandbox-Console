namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnage personnage = new Personnage();
            personnage.Naam = "Frodo";
            Console.WriteLine(personnage.Hallo());
            
            Held alperen = new Held("Samenvatten", "Alperen");
            alperen.Naam = "Alperen";
            alperen.SuperKracht = "Samenvatten";

            Console.WriteLine(alperen.Hallo());

            Monster monster = new Monster();
            Console.WriteLine(monster.Hallo());
        }
    }
}
