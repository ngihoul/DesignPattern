namespace FactoryPattern.Models
{
    public class ChasseColvert : Chasse
    {
        public override ICanard creerCanard()
        {
            return new Colvert();
        }
    }
}
