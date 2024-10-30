using CoinCoin.Models.Combattants.Interfaces;
using CoinCoin.Models.Combattants;

namespace CoinCoin.Models.Combattants
{
    internal class Agressif : Vivant
    {
        public override IVivant Combattre(IVivant other)
        {
            if (this.Vie <= 0 || Force - other.Defence <= 0)
            {
                return other;
            }
            else
            {
                Vie -= Math.Max(0, other.Force - Defence);
                return other.Combattre(this);
            }
        }

    }
}
