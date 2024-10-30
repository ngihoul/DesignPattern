using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class TurboCanard : Canard
    {
        public TurboCanard() : base(new VolerAvecDesReacteurs(), new Coincoin()) { }

        public override string Afficher()
        {
            return "Je suis un Turbo Canard !";
        }
    }
}
