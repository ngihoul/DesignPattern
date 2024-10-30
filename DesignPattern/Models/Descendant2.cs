namespace DesignPattern.Models
{
    public class Descendant2
    {
        private Ancetre _ancetre;

        public Descendant2(int compteur)
        {
            _ancetre = new Ancetre(compteur);
        }

        public string multiplier(int multiplicateur)
        {
            int compteur = getCompteur();
            int result = compteur * multiplicateur;

            return result.ToString();
        }

        public int getCompteur()
        {
            return _ancetre.getCompteur();
        }
    }
}
