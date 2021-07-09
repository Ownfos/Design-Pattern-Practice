using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Naive
{
    public class HammerRobot : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Swinging hammer");
        }

        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }
}
