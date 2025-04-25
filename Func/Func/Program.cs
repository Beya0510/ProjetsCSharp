namespace Func
{
    class Program
    {
        public void Executer(Func<int, int, int> operation)
        {
            int resultat = operation(4, 5);
            Console.WriteLine($"Résultat : {resultat}");
        }

        public void Executez(Func<int, int, int> operation, int a, int b)
        {
            int resultat = operation(a, b);
            Console.WriteLine($"Résultat : {resultat}");
        }

        public static void Main(string[] args)
        {
            Func<string> direBonjour = () => "Bonjour !";
            Console.WriteLine(direBonjour()); // Affiche : Bonjour !

            Func<int, int, int> addition = (a, b) => a + b;
            Console.WriteLine(addition(5, 7)); // Affiche : 12

            Func<int, int, int> multiplication = (c, d) => c * d;
            Console.WriteLine(multiplication(5, 8));

            Program program = new Program();
            program.Executer(addition);
            program.Executer(multiplication);
            program.Executez(addition, 4, 5);
            program.Executez(multiplication, 5, 8);

        }
    }
}