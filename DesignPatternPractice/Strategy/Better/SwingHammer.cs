using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Better
{
    public class SwingHammer : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Swinging hammer");
        }
    }
}
