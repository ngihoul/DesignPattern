using CoinCoin.Models.Canards;
using CoinCoin.Models.Canards.Interfaces;

namespace CoinCoin.Models.Chasseurs
{
    public class Proie : IAnimal
    {
        private ICancanVolant _Type;
        public Proie(ICancanVolant type)
        {
            _Type = type;
        }

        public string Crier()
        {
            return _Type.Cancaner();
        }

        public string Fuir()
        {
            return _Type.Voler();
        }
    }
}
