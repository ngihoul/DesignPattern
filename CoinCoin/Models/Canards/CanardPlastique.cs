using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class CanardPlastique : Canard
    {
        public CanardPlastique() : base(new NePasVoler(), new Muet())
        {
        }
        public override string Afficher()
        {
            return "Je suis un canard en plastique";
        }
    }
}
