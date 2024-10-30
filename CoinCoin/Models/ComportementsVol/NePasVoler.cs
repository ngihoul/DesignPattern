using CoinCoin.Models.ComportementsVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models.ComportementsVol
{
    internal class NePasVoler : IComportementVol
    {
        public string Voler()
        {
            return "Je ne sais pas voler";
        }
    }
}
