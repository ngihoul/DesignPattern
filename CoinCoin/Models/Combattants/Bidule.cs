using CoinCoin.Models.Canards;
namespace CoinCoin.Models.Combattants
{
    internal class Bidule
    {
        internal CanardVivant CreateColvertAgressif()
        {
            CanardVivant canardVivant = new CanardVivant();
            canardVivant.Canard = new Colvert();
            canardVivant.Vivant = CreateCombattant(10, 5, 2);
            
            return canardVivant;
        }

        internal CanardVivant CreateLeurrePacifique()
        {
            CanardVivant canardVivant = new CanardVivant();
            canardVivant.Canard = new Leurre();
            canardVivant.Vivant = new Pacifique();
            
            return canardVivant;
        }

        internal CanardVivant CreateMandarinAgressif()
        {
            CanardVivant canardVivant = new CanardVivant();
            canardVivant.Canard = new Mandarin();
            canardVivant.Vivant = CreateCombattant(10, 4, 2);
            
            return canardVivant;
        }


        private Agressif CreateCombattant(int v, int f, int d)
        {
            Agressif agressif = new Agressif();
            agressif.Vie = v;
            agressif.Force = f;
            agressif.Defence = d;
            
            return agressif;
        }

    }
}
