using CoinCoin.Models.ComportementsVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.ComportementsVol
{
    public class VolerAvecDesAiles : IComportementVol
    {
        public string Voler()
        {
            return "Je déploie mes ailes et vole";
        }
    }
}
