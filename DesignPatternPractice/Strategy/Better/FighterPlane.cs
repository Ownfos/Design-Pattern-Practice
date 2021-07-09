using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Better
{
    public class FighterPlane : Enemy
    {
        public FighterPlane()
        {
            attackStrategy = new FireBullets();
            moveStrategy = new Fly();
        }
    }
}
