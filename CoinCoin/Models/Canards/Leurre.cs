using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsVol;

namespace CoinCoin.Models.Canards
{
    public class Leurre : Canard
    {
        public Leurre() : base(new NePasVoler(), new Coincoin()) {}

        public override string Afficher()
        {
            return "Coi... Je suis un leurre !";
        }
    }
}
