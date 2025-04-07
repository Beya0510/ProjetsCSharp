namespace Polymorphisme;

public class Avion : Vehicule
{
    public Avion (string nom) :base(nom){ }
    
    public override void SeDeplacer()
    {
        Console.WriteLine($"L'avion de déplace en volant dans les airs.");
    }
}