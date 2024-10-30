using CoinCoin.Models.Canards;
using CoinCoin.Models.Combattants.Interfaces;

namespace CoinCoin.Models.Combattants
{
    public class CanardAgressif : CanardCombattant
    {

        public Canard Canard { get; set; }

        public CanardAgressif(Canard canard)
        {
            Canard = canard;
        }
        public override ICombattant Combattre(ICombattant adversaire)
        {
            if (adversaire == null || Vie <= 0 || adversaire.Force >= Defence)
            {
                throw new Exception("Combat impossible");
            }

            Vie = Vie - adversaire.Force;

            if (Vie == 0)
            {
                return adversaire;
            }
            else
            {
                return adversaire.Combattre(this);
            }
        }

        public override string Afficher()
        {
            return Canard.Afficher();
        }
    }
}
