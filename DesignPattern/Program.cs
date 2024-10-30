using DesignPattern.Models;

Descendant1 d1 = new Descendant1(2);
Descendant2 d2 = new Descendant2(3);

d1.getCompteur();
Console.WriteLine(d1.afficher());
Console.WriteLine(d1.afficher());

d2.getCompteur();
Console.WriteLine(d2.multiplier(3));
Console.WriteLine(d2.multiplier(4));
  
Console.WriteLine(d1.GetType());