using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Better
{
    public class HammerPlane : Enemy
    {
        public HammerPlane()
        {
            attackStrategy = new SwingHammer();
            moveStrategy = new Fly();
        }
    }
}
