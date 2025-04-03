namespace VoitureEncapsulation;

public class Moteur
{
    private int cylindres;
    private double puissanceEnCv;

    public Moteur(int cylindres, double puissanceEnCv)
    {
        this.cylindres = cylindres;
        this.puissanceEnCv = puissanceEnCv;
    }

    public int Cylindres => cylindres;
    public double PuissanceEnCv => puissanceEnCv;

    public void Demarrer() => Console.WriteLine("Le moteur démarre !");
    public void Arreter() => Console.WriteLine("Le moteur s'arrête.");
    
/*
 * Explication des messages affichés :
 
 * Les messages que vous voyez sont générés par les appels aux méthodes dans votre code.
 * Voici une explication de chaque message :

1. **"La voiture possède 4 roues."** : Ce message est généré par l'appel à `maVoiture.AfficherRoues();
     ` dans la méthode `Main `.

2. **"Jean conduit la voiture."** : Ce message est généré par l'appel à `jean.Conduire(maVoiture);
     ` dans la méthode `Main `.

3. **"La voiture démarre !"** et **"Le moteur démarre !"** : Ces messages sont générés par l'appel à 
     `voiture.DemarrerVoiture();` dans la méthode `Conduire` de la classe `Conducteur `.

4. **"La voiture s'arrête."** et **"Le moteur s'arrête."** : Ces messages sont générés par l'appel à 
     `maVoiture.ArreterVoiture();` dans la méthode `Main `.

5. **"Bonjour, bienvenue dans le monde de la programmation orientée objet !"** : Ce message est généré par l'appel à 
     `Console. WriteLine ("Bonjour, bienvenue dans le monde de la programmation orientée objet !") ;
     ` dans la méthode `Main `.

Voici le code de la méthode `Main` pour référence :


static void Main(string[] args)
{
    Moteur moteurV6 = new Moteur(6, 300.0);
    Roues roues = new Roues(4);
    Voiture maVoiture = new Voiture(moteurV6, roues);
    Conducteur jean = new Conducteur("Jean");

    maVoiture.AfficherRoues();
    jean.Conduire(maVoiture);
    maVoiture.ArreterVoiture();

    Console.WriteLine("Bonjour, bienvenue dans le monde de la programmation orientée objet !") ;
}


Chaque appel de méthode dans `Main` génère un ou plusieurs des messages que vous voyez.
 */
}