namespace DesignPattern.Models
{
    public class Ancetre
    {
        private int _compteur = 0;

        public Ancetre(int compteur)
        {
            _compteur = compteur;
        }

        public int getCompteur()
        {
            _compteur++;
            return _compteur;
        }
    }
}
