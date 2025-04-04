using PersonneEtudiantHeritage;
using System;



class Program
{
    static void Main(string[] args)
    {
        Exemple exemple = new Exemple("Ceci est un exemple");
        exemple.AfficherMessage();
        
        Etudiant etudiant = new Etudiant(52, 1, DateTime.Today);
        etudiant.SePresenter();
    }
}

