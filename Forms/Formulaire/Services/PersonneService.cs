using Formulaire.Models;

namespace Formulaire.Services;

public class PersonneService
{
    private Personne? _dernierePersonne;
    private readonly List<Personne> _personnes = new();

    public void EnregistrerPersonne(Personne personne)
    {
        _dernierePersonne = personne;
        _personnes.Add(personne);
    }

    public Personne? GetDernierePersonne()
    {
        return _dernierePersonne;
    }

    public List<Personne> GetToutesLesPersonnes()
    {
        return _personnes;
    }
    
    public void SupprimerPersonne(Personne personne)
    {
        _personnes.Remove(personne);
    }
}