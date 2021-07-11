using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public class Knight : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Swinging sword");
        }

        public override int GetATK()
        {
            return 10;
        }

        public override int GetHP()
        {
            return 200;
        }

        public override string GetName()
        {
            return "Knight";
        }
    }
}
