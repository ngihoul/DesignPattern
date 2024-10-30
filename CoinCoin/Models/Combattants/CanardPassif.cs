using CoinCoin.Models.Canards;
using CoinCoin.Models.Combattants.Interfaces;

 namespace CoinCoin.Models.Combattants
{
    public class CanardPassif : CanardCombattant
    {
        public Canard Canard { get; set; }

        public CanardPassif(Canard canard)
        {
            Canard = canard;
        }
        public override ICombattant Combattre(ICombattant adversaire)
        {
            return adversaire;
        }

        public override string Afficher()
        {
            return Canard.Afficher();
        }
    }
}
