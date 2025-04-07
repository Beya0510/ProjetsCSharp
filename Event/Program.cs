using System;
using System.Threading;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            // S'abonner à l'événement
            clock.SecondChanged += (sender, e) =>
            {
                Console.WriteLine($"Seconde {e.SecondsElapsed} écoulée à : {DateTime.Now:T}");
            };

            // Démarrer l'horloge
            clock.StartClock();
        }
    }
}