using CoinCoin.Models.Canards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.Eleveur
{
    public class Eleveur
    {
        public virtual string Soigner(Canard canard)
        {
            return "Soigneur Canard : je soigne un canard !";
        }
    }
}
