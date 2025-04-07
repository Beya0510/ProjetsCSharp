using System;

namespace Delegates
{
    class Program
    {
        // Déclaration du délégué
        delegate void Message();

        static void Main(string[] args)
        {
            // Méthodes locales
            void Bonjour() => Console.WriteLine("Bonjour !");
            void AuRevoir() => Console.WriteLine("Au revoir !");

            // Création du délégué
            Message msg = Bonjour;
            msg += AuRevoir;

            Console.WriteLine("=== Appel direct ===");
            msg(); // Appel direct
            Console.WriteLine();
            
            Console.WriteLine("=== Appel avec .Invoke() ===");
            msg.Invoke(); // Appel avec Invoke()
            Console.WriteLine();    
            
            Console.WriteLine("=== Appel avec .DynamicInvoke() ===");
            msg.DynamicInvoke(); // Appel avec DynamicInvoke()
            Console.WriteLine();

            // Délégué avec méthodes anonymes
            Message msg2 = delegate { Console.WriteLine("Hello !"); };
            msg2 += () => Console.WriteLine("Goodbye !");

            Console.WriteLine("=== Méthodes anonymes - Appel direct ===");
            msg2(); // Appel direct
        }
    }
}