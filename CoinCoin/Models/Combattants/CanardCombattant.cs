using CoinCoin.Models.Canards;
using CoinCoin.Models.Combattants.Interfaces;

namespace CoinCoin.Models.Combattants
{
    public class CanardCombattant : Canard, ICombattant
    {
        private int _Vie;
        private int _Force;
        private int _Defence;

        public int Vie { 
            get
            {
                return _Vie;
            } 
            set {
                if (_Vie + value < 0)
                {
                    _Vie = 0;
                }
                else
                {
                    _Vie = value;
                }
            }
        }

        public int Force { get; set; }
        public int Defence { get; set; }

        public void AddDefence(int defence)
        {
            Defence = Defence + defence;
        }

        public void AddForce(int force)
        {
            Force = Force + force;
        }

        public void AddVie(int vie)
        {
            Vie = Vie + vie;
        }

        public CanardCombattant()
        {
            Vie = Random.Shared.Next(100, 120);
            Force = Random.Shared.Next(1, 25);
            Defence = Random.Shared.Next(75, 100);
        }

        public virtual ICombattant Combattre(ICombattant adversaire)
        {
            return adversaire;
        }

        public override string Afficher()
        {
            return "Je suis un Canard Combattant";
        }
    }
}
