using VoitureEncapsulation;
using System;


class Program
{
    static void Main(string[] args)
    {
        Moteur moteurV6 = new Moteur(6, 300.0);
        Roues roues = new Roues(4);
        Voiture maVoiture = new Voiture(moteurV6, roues);
        Conducteur jean = new Conducteur("Jean");

        maVoiture.AfficherRoues();
        jean.Conduire(maVoiture);
        maVoiture.ArreterVoiture();

        Console.WriteLine("Bonjour, bienvenue dans le monde de la programmation orientée objet !");
    }
}