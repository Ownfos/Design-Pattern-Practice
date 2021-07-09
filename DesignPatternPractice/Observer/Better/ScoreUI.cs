using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Better
{
    public class ScoreUI : IObserver<int>
    {
        public void HandleInfo(int info)
        {
            Console.WriteLine($"Updating score UI to new score: {info}");
        }
    }
}
