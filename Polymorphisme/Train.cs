namespace Polymorphisme;

public class Train : Vehicule
{
    public Train(string nom) : base(nom) { }
    public override void SeDeplacer()
    {
        Console.WriteLine($"Le train se déplace en roulant sur les rails.");
    }
}