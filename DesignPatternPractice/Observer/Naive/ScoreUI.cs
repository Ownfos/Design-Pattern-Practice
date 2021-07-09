using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Naive
{
    public class ScoreUI
    {
        public void UpdateUI(int newScore)
        {
            Console.WriteLine($"Updating score UI to new score: {newScore}");
        }
    }
}
