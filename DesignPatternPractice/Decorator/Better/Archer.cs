using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public class Archer : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Shooting arrows");
        }

        public override int GetATK()
        {
            return 20;
        }

        public override int GetHP()
        {
            return 100;
        }

        public override string GetName()
        {
            return "Archer";
        }
    }
}
