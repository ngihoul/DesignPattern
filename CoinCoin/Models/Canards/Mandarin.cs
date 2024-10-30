using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class Mandarin : Canard
    {
        public Mandarin() : base(new VolerAvecDesAiles(), new Cancan()) { }
        public override string Afficher()
        {
            return "Je suis un mandarin !";
        }
    }
}
