namespace CoinCoin.Models.Combattants.Interfaces
{
    public interface IVivant
    {
        public int Vie { get; }
        public int Force { get; }
        public int Defence { get; }


        public void AddVie(int vie);
        public void AddForce(int force);
        public void AddDefence(int defence);

        public IVivant Combattre(IVivant adversaire);
    }
}
