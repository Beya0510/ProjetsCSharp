namespace VoitureEncapsulation;

public class Conducteur
{
    private string nom { get; set; }

    public Conducteur(string nom)
    {
        this.nom = nom;
    }

    public void Conduire(Voiture voiture)
    {
        Console.WriteLine($"{nom} conduit la voiture.");
        voiture.DemarrerVoiture();
    }
}