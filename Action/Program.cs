using System;
using System.Runtime.CompilerServices;
using static System.Action;

namespace Action
{
    class Program
    {
        
        public static void FaireQuelqueChose(System.Action action)
        {
            Console.WriteLine("Avant l'action.");
            action();  // Exécute l'Action passée en paramètre
            Console.WriteLine("Après l'action.");
        }
        
        public static event System.Action? AuthentificationChangee;

        public static void Login()
        {
            Console.WriteLine("Utilisateur connecté.");
            AuthentificationChangee?.Invoke();  // Déclenche l'événement
        }

        
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
            
            // Action sans paramètre
            System.Action direBonjour = () => Console.WriteLine("Bonjour !");
            direBonjour();  // Affiche : Bonjour !
            
            // Action avec paramètre
            Action<string> direNom = (nom) => Console.WriteLine($"Bonjour, {nom} !");
            direNom("Alice");  // Affiche : Bonjour, Alice !

            // Action avec plusieurs paramètres
            Action<int, int> addition1 = (a, b) => Console.WriteLine($"Résultat : {a + b}");
            addition1(5, 7);  // Affiche : Résultat : 12

            FaireQuelqueChose(() => Console.WriteLine("J'exécute une action !"));
            
            Login();
        }
    }
}

