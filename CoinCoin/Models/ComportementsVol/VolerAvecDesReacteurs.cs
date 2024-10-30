using CoinCoin.Models.ComportementsVol.Interfaces;

namespace CoinCoin.Models.ComportementsVol
{
    public class VolerAvecDesReacteurs : IComportementVol
    {
        public string Voler()
        {
            return "Je sors mes réacteurs ... et décolle !";
        }
    }
}
