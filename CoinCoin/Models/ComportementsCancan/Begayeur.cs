using CoinCoin.Models.ComportementsCancan.Interfaces;

namespace CoinCoin.Models.ComportementsCancan
{
    public class Begayeur : IComportementCancan
    {
        public IComportementCancan ComportementCancan;

        public Begayeur(IComportementCancan comportementCancan)
        {
            ComportementCancan = comportementCancan;
        }

        public string Cancaner()
        {
            return ComportementCancan.Cancaner() + ' ' + ComportementCancan.Cancaner();
        }
    }
}
