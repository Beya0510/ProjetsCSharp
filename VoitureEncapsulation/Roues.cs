namespace VoitureEncapsulation;

public class Roues
{
    private int nombreDeRoues;

    public Roues(int nombreDeRoues)
    {
        this.nombreDeRoues = nombreDeRoues;
    }

    public void AfficherRoues()
    {
        Console.WriteLine($"La voiture possède {nombreDeRoues} roues.");
    }
}