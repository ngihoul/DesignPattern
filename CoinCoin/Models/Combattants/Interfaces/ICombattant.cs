namespace CoinCoin.Models.Combattants.Interfaces
{
    public interface ICombattant
    {
        public int Vie { get; }
        public int Force { get; }
        public int Defence { get; }


        public void AddVie(int vie);
        public void AddForce(int force);
        public void AddDefence(int defence);

        public ICombattant Combattre(ICombattant adversaire);
    }
}
