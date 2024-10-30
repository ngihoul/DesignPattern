using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class TurboCanard : Canard
    {
        public TurboCanard()
        {
            ComportementCancan = new Coincoin();
            ComportementVol = new VolerAvecDesReacteurs();
        }
        public override string Afficher()
        {
            return "Je suis un Turbo Canard !";
        }
    }
}
