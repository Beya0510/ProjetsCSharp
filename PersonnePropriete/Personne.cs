namespace PersonnePropriete;

public class Personne
{
    // Propriété pour l'âge de Personne
    public int Age { get; set; }
    
    // Constructeur pour initialiser l'âge
    public Personne(int age)
    {
        Age = age;
    }    
    
    // Méthode pour afficher des informations sur la personne
    public override string ToString()
    {
        return $"Age: {Age}";
    }
}