namespace Interfaces;

// Classe principale qui contient le point d'entrée de l'application.
class Program
{
    // Méthode Main, point d'entrée de l'application.
    static void Main(string[] args)
    {
        // Appel de la méthode DessinerEnConsole avec une instance de Carre.
        DessinerEnConsole(new Carre());
        // Appel de la méthode DessinerEnConsole avec une instance de Cercle.
        DessinerEnConsole(new Cercle());
    }

    // Méthode DessinerEnConsole qui prend un paramètre de type IDessinable.
    static void DessinerEnConsole(IDessinable dessinable)
    {
        // Affiche le résultat de la méthode Dessiner de l'objet dessinable passé en paramètre.
        Console.WriteLine(dessinable.Dessiner());
    }
}
