namespace ClassesAbstraites;

public class Cercle : Forme
{
    private double rayon;

    public Cercle(double rayon)
    {
        this.rayon = rayon;
    }

    public override void Dessiner()
    {
        Console.WriteLine($"Dessiner un cercle de rayon {rayon}");
    }
    
}