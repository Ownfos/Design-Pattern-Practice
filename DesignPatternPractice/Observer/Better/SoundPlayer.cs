using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer.Better
{
    public class SoundPlayer : IObserver<int>
    {
        public void HandleInfo(int info)
        {
            Console.WriteLine("Playing sound effect");
        }
    }
}
