using CoinCoin.Models;
using CoinCoin.Models.Canards;
using CoinCoin.Models.Chasseurs;
using CoinCoin.Models.Combattants;
using CoinCoin.Models.Combattants.Interfaces;
using CoinCoin.Models.ComportementsCancan;
using CoinCoin.Models.ComportementsCancan.Interfaces;
using CoinCoin.Models.Eleveur;
using SuperCanard;

List<Canard> canards = new List<Canard>
{
    new Mandarin(),
    new Colvert(),
    new Leurre(),
    new CanardPlastique(),
    new TurboCanard(),
};

Console.WriteLine("*************");
Console.WriteLine("Pan pan ...");

foreach (Canard canard in canards)
{
    Console.WriteLine("*************");
    Console.WriteLine(canard.ComportementCancan = new Begayeur(new Begayeur(canard.ComportementCancan)));
    Console.WriteLine(canard.Nager());
    Console.WriteLine(canard.Voler());
    Console.WriteLine(canard.Cancaner());
    Console.WriteLine(canard.Afficher());
    Console.WriteLine("*************");
}
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* Ma super fusée *");
Console.WriteLine("*************");
Fusee fusee = new Fusee();
Console.WriteLine(fusee.Voler());
Console.WriteLine(fusee.Afficher());
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* Canard alternant *");
Console.WriteLine("*************");
Canard canardAlternant = new Mandarin();
List<IComportementCancan> cancans = new List<IComportementCancan>
{
    new Coincoin(),
    new Cancan(),
};

canardAlternant.ComportementCancan = new Alternant(cancans);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Cancan #{i} : {canardAlternant.Cancaner()}");
}
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* Canard bégayeur alternant *");
Console.WriteLine("*************");
Canard canardBegayeurAlternant = new Colvert();
List<IComportementCancan> cancansBegayeur = new List<IComportementCancan>
{
    new Begayeur(new Coincoin()),
    new Begayeur(new Cancan()),
};
canardBegayeurAlternant.ComportementCancan = new Alternant(cancansBegayeur);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Cancan #{i} : {canardBegayeurAlternant.Cancaner()}");
}
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* Cri composite *");
Console.WriteLine("*************");
IComportementCancan criComposite = TestComposite.buildCri();

Console.WriteLine(criComposite.Cancaner());
Console.WriteLine(criComposite.Cancaner());
Console.WriteLine(criComposite.Cancaner());
Console.WriteLine(criComposite.Cancaner());
Console.WriteLine(criComposite.Cancaner());
Console.WriteLine(criComposite.Cancaner());
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* Cri composite 2 *");
Console.WriteLine("*************");
IComportementCancan criComposite2 = TestComposite.buildCri2();

Console.WriteLine(criComposite2.Cancaner());
Console.WriteLine(criComposite2.Cancaner());
Console.WriteLine("*************");

Console.WriteLine("*************");
Console.WriteLine("* La chasse est ouverte *");
Console.WriteLine("*************");
Chasseur monChasseur = new Chasseur();
Canard monCanard = new Colvert();
monChasseur.Chasser(new Proie(monCanard));

Console.WriteLine("*************");
Console.WriteLine("* Elevage *");
Console.WriteLine("*************");
Eleveur e = new EleveurColvert();
EleveurColvert e2 = new EleveurColvert();
Eleveur e3 = new Eleveur();

Colvert c = new Colvert();

Console.WriteLine(e.Soigner(c));
Console.WriteLine(e2.Soigner(c));
Console.WriteLine(e3.Soigner(c));

Console.WriteLine(e3.Soigner(new Mandarin()));
Console.WriteLine("*************");

try
{
    Console.WriteLine("*************");
    Console.WriteLine("*  Combat ! *");
    Console.WriteLine("*************");
    CanardCombattant c1 = new CanardAgressif(new Colvert());
    CanardCombattant c2 = new CanardAgressif(new Leurre());
    Console.WriteLine($"Combattant #1 : {c1.Afficher()}");
    Console.WriteLine($"Combattant #2 : {c2.Afficher()}");


    CanardCombattant gagnant = (CanardCombattant) c2.Combattre(c1);
    Console.WriteLine($"Gagnant : {gagnant.Afficher()}");
    
    Console.WriteLine("*************");
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("*************");
}

