namespace Polymorphisme;

public class Voiture : Vehicule
{
    public Voiture(string nom) : base(nom){ }

    public override void SeDeplacer()
    {
        Console.WriteLine($"La voiture se déplace en roulant sur la route.");
    }
}