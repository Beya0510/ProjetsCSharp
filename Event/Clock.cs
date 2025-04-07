using System;
using System.Threading;

namespace Event;

    // Déclaration d'une classe dérivée de EventArgs
    public class SecondChangedEventArgs : EventArgs
    {
        public int SecondsElapsed { get; }

        public SecondChangedEventArgs(int secondsElapsed)
        {
            SecondsElapsed = secondsElapsed;
        }
    }

    // Délégué utilisant la nouvelle classe d'arguments
    public delegate void SecondChangedEvent(object sender, SecondChangedEventArgs e);

    public class Clock
    {
        public event SecondChangedEvent? SecondChanged;
        private int secondsElapsed = 0;

        public void StartClock()
        {
            while (true)
            {
                Thread.Sleep(1000);
                secondsElapsed++;
                OnSecondChanged(secondsElapsed);
            }
        }

        protected virtual void OnSecondChanged(int seconds)
        {
            // Création d'un objet EventArgs personnalisé et invocation
            SecondChanged?.Invoke(this, new SecondChangedEventArgs(seconds));
        }
    }