namespace ClassesAbstraites;

public class Program
{
    public static void Main(string[] args)
    {
        Forme rectangle = new Rectangle(5, 10);
        Forme cercle = new Cercle(7);
        
        rectangle.Dessiner();
        cercle.Dessiner();
    }
}