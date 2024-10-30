using CoinCoin.Models.Canards.Interfaces;
using CoinCoin.Models.ComportementsCancan.Interfaces;
using CoinCoin.Models.ComportementsVol.Interfaces;

namespace CoinCoin.Models.Canards
{
    public abstract class Canard : ICanard
    {
        public IComportementVol ComportementVol { get; set; }
        public IComportementCancan ComportementCancan { get; set; }

        protected Canard(IComportementVol comportementVol, IComportementCancan comportementCancan)
        {
            ComportementVol = comportementVol;
            ComportementCancan = comportementCancan;
        }

        public string Cancaner()
        {
            return ComportementCancan.Cancaner();
        }

        public string Nager()
        {
            return "Je nage";
        }

        public string Voler()
        {
            return ComportementVol.Voler();
        }

        public abstract string Afficher();

    }
}
