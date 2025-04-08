using System;
using static System.Action;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            // Action sans paramètre
            System.Action afficherMessage = () => Console.WriteLine("Action exécutée!");
            afficherMessage(); // Appel de l'action
            
            // Action avec un paramètre
            Action<string> afficherNom = (nom) => Console.WriteLine($"Bonjour, {nom}!");
            afficherNom("Grace Beya Mulumba"); // Appel de l'action avec un argument
            
            // Action avec plusieurs paramètres (ici 2)
            Action<int, int> addition = (a, b) => Console.WriteLine("La somme est : " + (a + b));
            addition(1, 2); // Appel de l'action avec deux arguments
            
            // Func avec 2 paramètres et un retour
            Func<int, int, int> multiplier = (a, b) => a * b;
            Console.WriteLine($"Résultat de la multiplication : {multiplier(1, 2)}");
            
            
        }
    }
}

