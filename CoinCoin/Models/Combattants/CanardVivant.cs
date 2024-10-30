using CoinCoin.Models.Canards.Interfaces;
using CoinCoin.Models.Combattants.Interfaces;

namespace CoinCoin.Models.Combattants
{
    public class CanardVivant : IVivant, ICanard
    {
        public int Vie => Vivant.Vie;

        public int Force => Vivant.Force;

        public int Defence => Vivant.Defence;

        internal ICanard Canard { get; set; }
        internal IVivant Vivant { get; set; }

        public void AddDefence(int defence)
        {
            Vivant.AddDefence(defence);
        }

        public void AddForce(int force)
        {
            Vivant.AddForce(force);
        }

        public void AddVie(int vie)
        {
            Vivant.AddVie(vie);
        }

        public string Afficher()
        {
            return Canard.Afficher();
        }

        public IVivant Combattre(IVivant other)
        {
            return Vivant.Combattre(other) == Vivant ? this : other;
        }

        public string Cancaner()
        {
            return Canard.Cancaner();
        }

        public string Voler()
        {
            return Canard.Voler();
        }

        public string Nager()
        {
            return Canard.Nager();
        }
    }
}
