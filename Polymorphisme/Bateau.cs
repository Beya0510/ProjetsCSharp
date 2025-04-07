namespace Polymorphisme;

public class Bateau : Vehicule
{
    public Bateau(string nom) : base (nom){ }
    public override void SeDeplacer()
    {
        Console.WriteLine($"Le bateau se déplace en naviguant sur l'eau.");
    }
}