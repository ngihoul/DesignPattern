using CoinCoin.Models.ComportementsVol;
using CoinCoin.Models.ComportementsVol.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCoin.Models
{
    public class Fusee
    {
        public IComportementVol ComportementVol { get; set; }

        public Fusee()
        {
            ComportementVol = new VolerAvecDesReacteurs();
        }

        public string Voler()
        {
            return ComportementVol.Voler();
        }

        public string Afficher()
        {
            return "Je suis une fusée";
        }
    }
}
