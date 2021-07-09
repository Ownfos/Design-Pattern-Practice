using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Better
{
    public class BoardGame : ISubject<int>
    {
        private int score;
        private List<IObserver<int>> observers;

        public BoardGame()
        {
            score = 0;
            observers = new List<IObserver<int>>();
        }

        public void IncrementScore(int amount)
        {
            Console.WriteLine($"Incrementing score by {amount}");
            score += amount;
            Notify(score);
        }

        public void AddObserver(IObserver<int> observer)
        {
            observers.Add(observer);
        }

        public void Notify(int info)
        {
            foreach(var observer in observers)
            {
                observer.HandleInfo(info);
            }
        }

        public void RemoveObserver(IObserver<int> observer)
        {
            observers.Remove(observer);
        }
    }
}
