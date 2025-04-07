namespace Animal;

class Program
{
    public static void Main(string[] args)
    {
        Animal animal1 = new Chien(); 
        Animal animal2 = new Chat();  
        
        
        animal1.Parler(); // Appelle la méthode Parler de la classe chien.
        animal2.Parler(); // Appelle la méthode Parler de la classe Chat.
        
    }
}