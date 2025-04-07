namespace  Polymorphisme;

using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Vehicule> vehicules = new List<Vehicule>()
        {
            new Voiture("Voiture"),
            new Bateau("Bateau"),
            new Avion("Avion"),
            new Train("train")
        }
        ;
        

        foreach (var vehicule in vehicules)
        {
            vehicule.SeDeplacer();
        }
    }
}

