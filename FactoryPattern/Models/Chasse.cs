namespace FactoryPattern.Models
{
    public abstract class Chasse
    {
        public void lancer()
        {
            Console.WriteLine("Lancer la chasse ? Y/N");
            string joue = Console.ReadLine()!;

            if(joue == "Y" || joue == "y")
            {
                Console.WriteLine("Chasse en cours ...");
                ICanard canard = creerCanard();
                Console.WriteLine(canard.Afficher());

                int chance = Random.Shared.Next(0, 5);

                Console.WriteLine("Pan ...");
                if (chance == 3)
                {
                    Console.WriteLine("Bravo !");
                } else
                {
                    Console.WriteLine("Perdu !");
                }
            }
        }

        public abstract ICanard creerCanard();
    }
}
