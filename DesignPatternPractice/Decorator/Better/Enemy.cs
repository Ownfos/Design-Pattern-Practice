using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public abstract class Enemy
    {
        public abstract int GetHP();
        public abstract int GetATK();
        public abstract string GetName();
        public abstract void Attack();
    }
}
