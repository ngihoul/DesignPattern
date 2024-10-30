using CoinCoin.Models.Combattants.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.Combattants
{
    internal class Pacifique : Vivant
    {
        public override IVivant Combattre(IVivant other)
        {
            return other;
        }
    }
}
