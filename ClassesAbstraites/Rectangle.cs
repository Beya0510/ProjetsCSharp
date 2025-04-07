namespace ClassesAbstraites;

public class Rectangle : Forme
{
    private double longueur;
    private double largeur;

    public Rectangle(double longueur, double largeur)
    {
        this.longueur = longueur;
        this.largeur = largeur;
    }

    public override void Dessiner()
    {
        Console.WriteLine($"Dessiner un rectangle de longueur {longueur} et de largeur {largeur}");
    }
}