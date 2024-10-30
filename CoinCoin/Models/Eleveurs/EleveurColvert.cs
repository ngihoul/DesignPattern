using CoinCoin.Models.Canards;

namespace CoinCoin.Models.Eleveur
{
    public class EleveurColvert : Eleveur
    {
        public override string Soigner(Canard canard)
        {
            return "Soigneur Colvert : Je soigne un canard";
        }

        public string Soigner(Colvert colvert)
        {
            return "Soigneur Colvert : Je soigne un Colvert";
        }
    }
}
