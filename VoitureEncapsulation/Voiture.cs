namespace VoitureEncapsulation;

public class Voiture
{
    private Moteur moteur;
    private Roues roues;

    public Voiture(Moteur moteur, Roues roues)
    {
        this.moteur = moteur;
        this.roues = roues;
    }

    public void DemarrerVoiture()
    {
        Console.WriteLine("La voiture démarre !");
        moteur.Demarrer();
    }

    public void ArreterVoiture()
    {
        Console.WriteLine("La voiture s'arrête.");
        moteur.Arreter();
    }

    public void AfficherRoues()
    {
        roues.AfficherRoues();
    }
}