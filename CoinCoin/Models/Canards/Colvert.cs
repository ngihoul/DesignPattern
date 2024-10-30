using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;
using System;
using System.Collections.Generic;
namespace CoinCoin.Models.Canards
{
    public class Colvert : Canard
    {
        public Colvert() : base(new VolerAvecDesAiles(), new Coincoin())
        {
        }
        public override string Afficher()
        {
            return "Je suis un colvert";
        }
    }
}
