using CoinCoin.Models.Canards;

namespace CoinCoin.Models.Chasseurs
{
    public class Proie : IAnimal
    {
        private Canard _Type;
        public Proie(Canard type)
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
