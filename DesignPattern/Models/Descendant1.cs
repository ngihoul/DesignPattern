namespace DesignPattern.Models
{
    public class Descendant1
    {
        private Ancetre _ancetre;

        public Descendant1(int compteur)
        {
            _ancetre = new Ancetre(compteur);
        }

        public string afficher()
        {
            return getCompteur().ToString();
        }

        public int getCompteur()
        {
            return _ancetre.getCompteur();
        }
    }
}
