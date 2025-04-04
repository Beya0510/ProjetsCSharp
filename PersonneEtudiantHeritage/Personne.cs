namespace PersonneEtudiantHeritage;

public class Personne
{
    public int Age { get; set; }

    public Personne(int age)
    {
        Age = age;
    }    
    
    public virtual string SePresenter()
    {
        return "Je suis une personne.";
    }

    public override string ToString()
    {
        return $"Personne de {Age} ans.";
    }
}