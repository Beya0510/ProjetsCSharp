namespace Polymorphisme;

public  abstract class Vehicule
{
    public string Nom {get; set;}

    public Vehicule(string nom)
    {
        Nom = nom;
    }    
    
    public virtual void SeDeplacer()
    {
        Console.WriteLine($"Le véhicule se déplace.");
    }
    
}