namespace FactoryPattern.Models
{
    public class ChasseMandarin : Chasse
    {
        public override ICanard creerCanard()
        {
            return new Mandarin();
        }
    }
}
