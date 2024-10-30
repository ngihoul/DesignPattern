using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class Leurre : Canard
    {
        public Leurre()
        {
            ComportementVol = new NePasVoler();
            ComportementCancan = new Coincoin();
        }
        public override string Afficher()
        {
            return "Coi... Je suis un leurre !";
        }
    }
}
