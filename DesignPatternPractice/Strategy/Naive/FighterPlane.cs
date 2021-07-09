using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Naive
{
    public class FighterPlane : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Firing bullets");
        }

        public void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}
