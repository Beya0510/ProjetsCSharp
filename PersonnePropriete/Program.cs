using PersonnePropriete;

class Program
{
    public static void Main(string[] args)
    {
        // Création d'une instance Personne
        Personne personne = new Personne(52);
        
        // Affichage de l'âge de la personne
        Console.WriteLine(personne.ToString());
    }
}
