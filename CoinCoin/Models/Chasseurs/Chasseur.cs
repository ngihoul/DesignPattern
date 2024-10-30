namespace CoinCoin.Models.Chasseurs
{
    public class Chasseur
    {
        public void Chasser(IAnimal animal)
        {
            Console.WriteLine("PAN");
            Console.WriteLine(animal.Crier());
            Console.WriteLine(animal.Fuir());
        }
    }
}
